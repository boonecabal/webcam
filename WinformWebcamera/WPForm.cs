using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WordPressPCL;
using RestSharp;

namespace Webcam
{
	public partial class WPForm : Form
	{
		private readonly string imagePath;
		public WPForm(string _imagePath)
		{
			imagePath = _imagePath;
			InitializeComponent();
		}

		private void WPForm_Load(object sender, EventArgs e)
		{
			this.Enabled = false;
			this.UseWaitCursor = true;
			this.btnClose.Enabled = false;
			try
			{

				//var data = await RestHelper.GetAll();
				//txtOutput.Text = RestHelper.BeautifyJson(data);
				// Create a client and a request
				string url = Properties.Settings.Default.OGDEN_URL_LOCAL;
				var client = new RestClient(url);
				var request = new RestRequest(url, Method.Post);
				// Add the file parameter
				request.AddFile("async-upload", imagePath);
				// Execute the request and get a response
				var response = client.Execute(request);
				// Check the response status
				if (response.IsSuccessful)
				{
					Console.WriteLine("File uploaded successfully.");
				}
				else
				{
					Console.WriteLine("File upload failed: " + response.ErrorMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Greetings, Fiend", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Enabled = true;
				this.lblMsg.Text = "Image sent to server, fiend.";
				this.UseWaitCursor = false;
				this.btnClose.Enabled = true;

			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
