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
using System.IO;

namespace Gold_Resolver
{
	public partial class website : Form
	{
		public website()
		{
			InitializeComponent();
		}

		private void website_Load(object sender, EventArgs e)
		{
			this.web.Navigate("");

			this.AutoSize = true;
			this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.Text = "URL Opener";

			closewebsite.AutoSize = true;
			closewebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.Controls.Add(closewebsite);
		}

		private void closewebsite_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
