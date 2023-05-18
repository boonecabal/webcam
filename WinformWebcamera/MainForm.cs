using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading;

namespace Webcam
{
	public partial class MainForm : Form
	{
		VideoCaptureDevice frame = null;
		FilterInfoCollection Devices;

		public MainForm()
		{
			InitializeComponent();
		}

		void Start_cam()
		{
			Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			frame = new VideoCaptureDevice(Devices[0].MonikerString);
			frame.NewFrame += new AForge.Video.NewFrameEventHandler(NewFrame_event);
			frame.Start();
		}
		void NewFrame_event(object send, NewFrameEventArgs e)
		{
			try
			{
				pbxCamera.Image = (Image)e.Frame.Clone();
			}
			catch (Exception ex) { }
		}

		private void button4_Click(object sender, EventArgs e)
		{
			btnStop.BringToFront();
			pbxCamera.BringToFront();

			grpCaptureMode.Visible = true;
			cboCaptureMode.Visible = true;
			UpdateCaptureModeControls();

			grpCaptureMode.Enabled = true;
			btnStart.Enabled = false;
			btnStop.Visible = true;

			Start_cam();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			frame.Stop();
			captureTimer.Stop();

			pbxCamera.Image = null;
			pbxOutput.Image = null;
			
			grpCaptureMode.Visible= false;

			btnTakeImage.Visible = false;
			btnStart.BringToFront();

			grpCaptureMode.Enabled = false;
			btnStart.Enabled = true;
			btnStop.Visible = false;

			cboCaptureMode.Visible = false;

			btnStartCapturing.Visible = false;
			btnPauseCapturing.Visible = false;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK && this.folder != folderBrowserDialog1.SelectedPath)
			{
				//txtOutputImagePath.Text = folderBrowserDialog1.SelectedPath;
				//output = folderBrowserDialog1.SelectedPath;
				SetStatus(folderBrowserDialog1.SelectedPath);

				btnRunCustomURL.Visible = true;
				btnStart.Visible = true;
				btnStop.Visible = true;
				btnRunCustomURL.Visible = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			if (this.folder != "" && pbxCamera.Image != null)
			{
				pbxCamera.Image.Save(this.imagePath);
				pbxOutput.Image = (Bitmap)pbxCamera.Image.Clone();
				pbxCamera.Image = null;

				pbxOutput.BringToFront();
				btnStart.BringToFront();
				btnTakeImage.Visible = false;
				btnWP.Visible = true;
				sb.Items[0].Text = imagePath;
				sb.Items[1].Text = "Picture taken";

				btnStop.Visible = false;
				btnStart.Enabled = true;
			}
			if (frame != null)
			{
				frame.Stop();
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			if (! Directory.Exists(capturedImagesFolder))
			{
				Directory.CreateDirectory(capturedImagesFolder);

			}
		}

		public string imagePath { 
			get
			{
				return this.folder + "\\Image.png";
			}
		}

		public string capturedImagesFolder
		{
			get
			{
				return string.Format("{0}\\CapturedImages", AppDomain.CurrentDomain.BaseDirectory);
			}
		}

		private void SetStatus(string status)
		{
			sb.Items[0].Text = status;
			statusTimer.Start();
		}

		private void status_DoubleClick(object sender, EventArgs e)
		{
			Clipboard.SetText(this.imagePath);
			sb.Items[1].Text = "Copied path to clipboard";
		}

		/// <summary>
		/// Executes a shell command synchronously.
		/// </summary>
		/// <param name="command">string command</param>
		/// <returns>string, as output of the command.</returns>
		public void ExecuteCommandSync(object command)
		{
			try
			{
				// create the ProcessStartInfo using "cmd" as the program to be run,
				// and "/c " as the parameters.
				// Incidentally, /c tells cmd that we want it to execute the command that follows,
				// and then exit.
				System.Diagnostics.ProcessStartInfo procStartInfo =
					 new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

				// The following commands are needed to redirect the standard output.
				// This means that it will be redirected to the Process.StandardOutput StreamReader.
				procStartInfo.RedirectStandardOutput = true;
				procStartInfo.UseShellExecute = false;
				// Do not create the black window.
				procStartInfo.CreateNoWindow = true;
				// Now we create a process, assign its ProcessStartInfo and start it
				System.Diagnostics.Process proc = new System.Diagnostics.Process();
				proc.StartInfo = procStartInfo;
				proc.Start();
				// Get the output into a string
				string result = proc.StandardOutput.ReadToEnd();
				// Display the command output.
				Console.WriteLine(result);
			}
			catch (Exception objException)
			{
				// Log the exception
			}
		}

		private void btnRunCustomURL_Click(object sender, EventArgs e)
		{
			ExecuteCommandSync("CustomURLProtocol.exe");
		}

		private void btnExit_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void btnWP_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			this.UseWaitCursor = true;
			SetStatus("Sending image to server, fiend...");
			try
			{
				var result = await SendImageToServer(this.imagePath);
			}
			catch (Exception ex)
			{
				captureTimer.Stop();
				SetStatus($"Error: {ex.Message}");

				//MessageBox.Show(ex.Message, "Greetings, Fiend", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Enabled = true;
				SetStatus("Image sent to server, fiend.");
				this.UseWaitCursor = false;
			}
		}

		private static async Task<bool> SendImageToServer(string imageFilePath)
		{

			/*
			 *  /api/v1/customer_photo
			 */
			var options = new RestClientOptions("http://127.0.0.1:5000/")
			{
				Authenticator = new HttpBasicAuthenticator("boone.cabal@gmail.com", "grantaster")
			};
			var client = new RestClient(options);

			var request = new RestRequest("/api/v1/customer_photo")
			{
				Authenticator = new HttpBasicAuthenticator("boone.cabal@gmail.com", "grantaster")
			};
			request.AddFile("async-upload", imageFilePath);

			var response = await client.PostAsync(request);
			return response.IsSuccessStatusCode;

		}

		private void btnInstallCpp_Click(object sender, EventArgs e)
		{
			try
			{ 
				ExecuteCommandSync("vcredist_x86.exe");
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message, "Greetings, Fiend", MessageBoxButtons.OK, MessageBoxIcon.Error);
				SetStatus($"Error: {ex.Message}");
			}
		}

		private async void captureTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				captureTimer.Stop();

				string capturedImagePath = CaptureImage();
				var response = await SendImageToServer(capturedImagePath);

				SetStatus("Captured image");
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message, "Greetings, Fiend", MessageBoxButtons.OK, MessageBoxIcon.Error);
				SetStatus($"Error: {ex.Message}");
			}
			finally
			{
				captureTimer.Start();
			}
		}

		private void CaptureSingleImage()
		{
			if (this.folder != "" && pbxCamera.Image != null)
			{
				string imagePath = string.Format("{0}\\image.png");
				pbxCamera.Image.Save(imagePath);
				pbxOutput.Image = (Bitmap)pbxCamera.Image.Clone();
				pbxCamera.Image = null;

			}
			if (frame != null)
			{
				frame.Stop();
			}
		}

		private string CaptureImage()
		{

			captureTimer.Stop();

			string imageFullFilename = string.Format("{0}\\capture_{1}.png", capturedImagesFolder, capturedImageCount);
			capturedImageCount++;
			if (this.folder != "" && pbxCamera.Image != null)
			{
				pbxCamera.Image.Save(imageFullFilename);
			}
			return imageFullFilename;

		}

		private string folder = string.Empty;

		private void cboCaptureMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCaptureModeControls();
		}

		private void UpdateCaptureModeControls()
		{
			if (cboCaptureMode.SelectedIndex == -1)
			{
				cboCaptureMode.SelectedIndex = 1;
			
			}
			if (cboCaptureMode.SelectedItem.ToString() == "Single")
			{
				btnTakeImage.Visible = true;

				btnStartCapturing.Visible = false;
				btnPauseCapturing.Visible = false;
			}
			else
			{
				btnTakeImage.Visible = false;

				btnStartCapturing.Visible = true;
				btnPauseCapturing.Visible = true;
			}

			SetStatus(string.Format("Capture mode set to {0}", cboCaptureMode.SelectedItem.ToString()));
		}

		private void btnStartCapturing_Click(object sender, EventArgs e)
		{
			captureTimer.Start();

			/*
			 *  /api/v1/active_customer
			 */
			//var options = new RestClientOptions("http://127.0.0.1:5000/")
			//{
			//	Authenticator = new HttpBasicAuthenticator("boone.cabal@gmail.com", "grantaster")
			//};
			//var client = new RestClient(options);

			//var request = new RestRequest($"/api/v1/active_customer/{1}")
			//{
			//	Authenticator = new HttpBasicAuthenticator("boone.cabal@gmail.com", "grantaster")
			//};
			//var response = await client.PutAsync(request);

			btnStartCapturing.Enabled = false;
			btnPauseCapturing.Visible = true;

			//if (! response.IsSuccessStatusCode)
			//{
			//	SetStatus("/api/v1/active_customer/<int:id> failed, fiend.");
			//}
		}

		private void btnPauseCapturing_Click(object sender, EventArgs e)
		{
			frame.Stop();
			captureTimer.Stop();

			//pbxOutput.Image = null;
			//pbxCamera.Image = null;

			btnStartCapturing.Enabled = true;
			btnPauseCapturing.Visible = false;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			frame.Stop();
		}

		private void statusTimer_Tick(object sender, EventArgs e)
		{
			sb.Items[0].Text = string.Empty;

			statusTimer.Stop();
		}

		private string captureMode = "Single";
		private List<Bitmap> capturedImages = new List<Bitmap>();
		private int capturedImageCount = 0;
	}
}
