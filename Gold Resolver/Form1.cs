using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Net.Security;
using System.Text.RegularExpressions;

namespace Gold_Resolver
{
    public partial class Form1 : Form
    {
		RegistryKey reg_key;

        public Form1()
        {
            InitializeComponent();
			websitepanel.Visible = false;
			//startproxy.Start();
			statusbox.Interval = 2000;
			statusbox.Start();
			hideSubMenu();
			userinfospanelinfos.Start();
			button2.Enabled = false;
			button3.Enabled = false;
			button5.Enabled = false;
			licencevalidenter.Start();
			this.panel3.Size = new System.Drawing.Size(700, 470);
			openChildForm(new paneldefaut());
		}


		private void hideSubMenu()
		{
			panelMediaSubMenu.Visible = false;
			panelPlaylistSubMenu.Visible = false;
			panelToolsSubMenu.Visible = false;
			otherpanel.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			//reg_key.SetValue("ProxyEnable", 0);
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new skypetoip());
		}

		private Form activeForm = null;

		private void openChildForm(Form childForm)
		{
			if (activeForm != null) activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			//websitepanel.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			//websitepanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void openwebsite(Form childForm)
		{
			if (activeForm != null) activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			websitepanel.Controls.Add(childForm);
			websitepanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void btnMedia_Click(object sender, EventArgs e)
		{
			showSubMenu(panelMediaSubMenu);
		}

		private void btnPlaylist_Click(object sender, EventArgs e)
		{
			showSubMenu(panelPlaylistSubMenu);
		}

		private void btnTools_Click(object sender, EventArgs e)
		{
			showSubMenu(panelToolsSubMenu);
		}

		private void other_Click(object sender, EventArgs e)
		{
			
		}

		private void other_Click_1(object sender, EventArgs e)
		{
			showSubMenu(otherpanel);
		}

		private void panelreseaux_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void joindiscord_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
		}

		private void discord_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			openChildForm(new iptoskype());
		}

		private void button5_Click(object sender, EventArgs e)
		{
			openChildForm(new emailtoskype());
		}

		private void button8_Click(object sender, EventArgs e)
		{
			openChildForm(new DNSResolver());
		}

		private void button7_Click(object sender, EventArgs e)
		{
			openChildForm(new CloudFlareResolver());
		}

		private void button6_Click(object sender, EventArgs e)
		{
			openChildForm(new WebsiteHeaders());
		}

		private void proxy_Tick(object sender, EventArgs e)
		{


			reg_key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\windows\\CurrentVersion\\Internet Settings", true);
				string v = ip.Text + ":" + port.Text;
			string proxy = v;
			reg_key.SetValue("ProxyEnable", 1);
			reg_key.SetValue("ProxyServer",proxy);

		}

		private void button11_Click(object sender, EventArgs e)
		{
			proxy.Start();
		}

		private void startproxy_Tick(object sender, EventArgs e)
		{
			WebClient proxyip = new WebClient();
			ip.Text = proxyip.DownloadString("");
			WebClient proxyport = new WebClient();
			port.Text = proxyport.DownloadString("");
		}

		private void test_Tick(object sender, EventArgs e)
		{
			button2.Enabled = true;
			button3.Enabled = true;
			button5.Enabled = true;
			button8.Enabled = true;
			button7.Enabled = true;
			button6.Enabled = true;
			button13.Enabled = true;
			button12.Enabled = true;
			button10.Enabled = true;
			button14.Enabled = true;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			openChildForm(new Resolvedatabase());
		}

		private void button12_Click(object sender, EventArgs e)
		{
			openChildForm(new ipgeo());
		}

		private void button10_Click(object sender, EventArgs e)
		{
			openChildForm(new iplogger());
		}

		private void button14_Click(object sender, EventArgs e)
		{
			openChildForm(new emailchecker());
		}

		private void statusbox_Tick(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://discord.gg/3t2568W");

		private void reloadStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void button15_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button32_Click(object sender, EventArgs e)
		{
			openChildForm(new userinfosform());
		}

		private void button18_Click(object sender, EventArgs e)
		{
			openwebsite(new plan());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//this.website.Navigate("");
		}

		private void button17_Click(object sender, EventArgs e)
		{
			openwebsite(new websitepetit());
			websitepanel.Visible = true;
			closewebsite.Visible = true;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			//==============================
			websitepanel.Visible = false;
			closewebsite.Visible = false;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			new website().Show();
		}

		private void button28_Click(object sender, EventArgs e)
		{
			openChildForm(new plan());
		}

		private void button63_Click(object sender, EventArgs e)
		{

		}

		private void button16_Click(object sender, EventArgs e)
		{
			openChildForm(new questionform());
		}

		private void flasepanelorform_Tick(object sender, EventArgs e)
		{
			//No coding...
		}

		private void q_Click(object sender, EventArgs e)
		{

			if (licencevalid.Text == licence.Text)
			{
				a.Visible = false;
				q.Visible = false;
				licence.Visible = false;
				label1.Visible = false;

				button2.Enabled = true;
				button3.Enabled = true;
				button5.Enabled = true;
				button8.Enabled = true;
				button7.Enabled = true;
				button6.Enabled = true;
				button13.Enabled = true;
				button12.Enabled = true;
				button10.Enabled = true;
				button14.Enabled = true;
				label2.Visible = true;
				youtubevideo.Visible = true;
			}
			else

				MessageBox.Show("LICENCE INVALID !");


			{
			}
		}

		private void licencevalidenter_Tick(object sender, EventArgs e)
		{
			WebClient key = new WebClient();
			licenceici.Text = key.DownloadString("");
		}

		private void ytb_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtube.com/oldmodz95");
		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://twitter.com/oldmodz95");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtube.com/oldmodz95");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			panel3.Visible = false;
			button2.Enabled = true;
			button3.Enabled = true;
			button5.Enabled = true;
			button8.Enabled = true;
			button7.Enabled = true;
			button6.Enabled = true;
			button13.Enabled = true;
			button12.Enabled = true;
			button10.Enabled = true;
			button14.Enabled = true;
		}

		private void youtubevideo_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("");
		}
	}
}
