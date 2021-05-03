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
	public partial class websitepetit : Form
	{
		public websitepetit()
		{
			InitializeComponent();
			web.ScriptErrorsSuppressed = true;
		}

		private void websitepetit_Load(object sender, EventArgs e)
		{
			this.web.Navigate(");
		}
	}
}
