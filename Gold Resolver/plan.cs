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
	public partial class plan : Form
	{
		private const bool V = true;

		public plan()
		{
			InitializeComponent();
			diamant.Visible = V;
			diamant1.Visible = V;
			vip.Visible = V;
		}

		private void button63_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
