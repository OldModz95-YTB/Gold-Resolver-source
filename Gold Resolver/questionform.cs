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
	public partial class questionform : Form
	{
		public questionform()
		{
			InitializeComponent();
			sendquestion.Start();
			fr.Visible = true;
			usa.Visible = true;
			WebClient webquestiontime = new WebClient();
			questionfrusa.Text = webquestiontime.DownloadString("");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fr_Click(object sender, EventArgs e)
		{
			WebClient webquestionfr = new WebClient();
			questionfrusa.Text = webquestionfr.DownloadString("");
		}

		private void usa_Click(object sender, EventArgs e)
		{
			WebClient webquestionen = new WebClient();
			questionfrusa.Text = webquestionen.DownloadString("");
		}

		private void sendquestion_Tick(object sender, EventArgs e)
		{
			
		}
	}
}
