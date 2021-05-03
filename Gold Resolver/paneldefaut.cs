using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Gold_Resolver
{
	public partial class paneldefaut : Form
	{
		public paneldefaut()
		{
			InitializeComponent();
			timerstatus.Start();
		}

		private void ytb_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtube.com/oldmodz95");
		}

		private void timerstatus_Tick(object sender, EventArgs e)
		{
			WebClient statustxt = new WebClient();
			status.Text = statustxt.DownloadString("");
			WebClient updatetxt = new WebClient();
			update.Text = updatetxt.DownloadString("");
		}

		private void closewebsite_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void statusclic_Opening(object sender, CancelEventArgs e)
		{
			timerstatus.Start();
		}
	}
}
