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
	public partial class iptoskype : Form
	{
		public iptoskype()
		{
			InitializeComponent();
			labelcapcha.Visible = false;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void validecaptcha_Click(object sender, EventArgs e)
		{
			labelcapcha.Visible = true;
			String[] strLabel = {
"g54cBLZM",
"K27UdbBX",
"tQh1J9ED",
"St1rC5QZ",
"fKN86dQG",
"MyQCQ82c",
"a7AC2jWK",
"H7vS6VfQ",
"9sSHB3Yd",
"4GB6yaUR",
"2a3KGZaH",
"p2JEwPS1",
"4fXp6SUU",
"Y82yUNQv",
"Pr6CxC8C",
"GS6B6Jtw",
"YGtB4Qw5",
"9JWEbK6r",
"v6uC9MGA",
"x7kR3LSG",
"5ZhzAUZ7",
"HZJg72qJ",
"5sAZ9wPM",
"u2R1MAGt",
"EvNSN67k",
"w9CdNM9R",
"Dk4qJNP7",
"PC3KtLe2",
"DSnR54Xz",
"Pv3Pu1MP",
"GC9C4uvS",
"SY5Mg3pT",
"JTJVv35u",
"U5FsGdX2",
"7ZUP7sVd",
"aPGwS5H5",
"N4PzfSZ5",
"LUQsH7q2",
"CQ5fGd3M",
"ZZ2Nus2P",
"DD6fUB9w",
"uyUA6JS6",
"T5Q8RFfd",
"SwH2R4Qv",
"Nx2UWQm4",
"syFBCH14",
"eEYSG74j",
"1MBJ7Nub",
"Yt87RJaY",
"CJ2Yk4qN",
"AVKm1M7m",
"12BFtCMs",
"Ky4W9PXj",
"E2YbhDN7",
"GB8gTAe1",
"61fYZKDh",
"U4jKG1Yv",
"8fYK6yNL",
"rFDB77Af",
"13wUWUWa",
"ydWP55NS",
"6cJTKW5q",
"Jm2AmAG7",
"eBD8Ln3A",
"H5pDWNk5",
"MQGf6M8m",
"nLHq69VZ",
"VySCc91V",
"NbSE71Gg",
"Y8v8FZLt",
"GEL7Mjk8",
"B88LTsxN",
"m8ZZPK8f",
"VvJ7N9nE",
"atQBL7M8",
"PRU3rMq5",
"RLqyE4U7",
"GacN77BP",
"YhaWB7U6",
"HN5gW8vH",
"V77KgjBZ",
"tz9X6YRP",
"M3zvL5WC",
"Xx2ATR6w",
"SJMp76Dy",
"6L9jRmRD",
"hM3e5ZXF",
"E8D2WdGn",
"LnB8RnJ8",
"8WQ9cMvK",
"C2CtD1Yh",
"MMnX74yJ",
"7Fz9YTYt",
"93DTsgGU",
"8kmKZTT6",
"NzQcUP88",
"W8ByZR2q",
"P6xQx8SP",
"kA39aVUH",
"cyQX2L1T",

};
			Random r = new Random();
			int iSelect = r.Next(0, 100);
			labelcapcha.Text = strLabel[iSelect];
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (captcha.Text == "" + labelcapcha.Text)
			{
				WebClient key = new WebClient();
				exe.Text = key.DownloadString("");
				response.AppendText("\r\nReussi");
				labelcapcha.Visible = false;
				WebClient skypetoip = new WebClient();
				const string V = "&action=ip2skype&string=";
				string IPV2 = skypetoip.DownloadString(exe.Text + V + skype.Text);
				response.Text = IPV2;
			}
			else

				response.Clear();
			labelcapcha.Visible = false;
			captcha.Text = "";


			{
			}
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			response.Clear();
		}
	}
}
