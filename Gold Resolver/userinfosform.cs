using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold_Resolver
{
	public partial class userinfosform : Form
	{
		public userinfosform()
		{
			InitializeComponent();
			started_infos.Start();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void started_infos_Tick(object sender, EventArgs e)
		{
			userinfoslabel.Text = " Username: " + Environment.UserName;
			machine.Text = " Machine Name: " + Environment.MachineName;
			osversion.Text = " OS Version: " + Environment.OSVersion;
			system64.Text = " System 64: " + Environment.Is64BitOperatingSystem;
			process64.Text = "Process 64: " + Environment.Is64BitProcess;
			ProcessorCount.Text = " Processor Count: " + Environment.ProcessorCount;
			Millisecondsystemstarted.Text = " System Started: " + Environment.TickCount;
			windowsversion.Text = " Windows Version: " + Environment.Version;
		}
	}
}
