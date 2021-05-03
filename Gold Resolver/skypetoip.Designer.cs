namespace Gold_Resolver
{
	partial class skypetoip
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.skype = new ZBobb.AlphaBlendTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.response = new ZBobb.AlphaBlendTextBox();
            this.responseclic = new theme.FlatContextMenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistfr = new System.Windows.Forms.Label();
            this.blacklisten = new System.Windows.Forms.Label();
            this.captcha = new ZBobb.AlphaBlendTextBox();
            this.GoldResolver = new System.Windows.Forms.Label();
            this.captchatimer = new System.Windows.Forms.Timer(this.components);
            this.captchaletter = new System.Windows.Forms.Label();
            this.labelcapcha = new System.Windows.Forms.Label();
            this.validecaptcha = new System.Windows.Forms.Button();
            this.exe = new System.Windows.Forms.Label();
            this.responseclic.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(28, 336);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(254, 32);
            this.button9.TabIndex = 17;
            this.button9.Text = "Resolve IP";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(50, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Skype To IP";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(676, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // skype
            // 
            this.skype.BackAlpha = 100;
            this.skype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skype.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skype.ForeColor = System.Drawing.Color.White;
            this.skype.Location = new System.Drawing.Point(28, 219);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(254, 25);
            this.skype.TabIndex = 19;
            this.skype.Tag = "";
            this.skype.Text = "Skype Name";
            this.skype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "[+] Response";
            // 
            // response
            // 
            this.response.BackAlpha = 100;
            this.response.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.response.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.response.ContextMenuStrip = this.responseclic;
            this.response.Cursor = System.Windows.Forms.Cursors.No;
            this.response.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response.ForeColor = System.Drawing.Color.White;
            this.response.Location = new System.Drawing.Point(347, 126);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.ReadOnly = true;
            this.response.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.response.Size = new System.Drawing.Size(324, 254);
            this.response.TabIndex = 20;
            this.response.Tag = "";
            this.response.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // responseclic
            // 
            this.responseclic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.responseclic.ForeColor = System.Drawing.Color.White;
            this.responseclic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.responseclic.Name = "flatContextMenuStrip1";
            this.responseclic.ShowImageMargin = false;
            this.responseclic.Size = new System.Drawing.Size(76, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // blacklistfr
            // 
            this.blacklistfr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blacklistfr.AutoSize = true;
            this.blacklistfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistfr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.blacklistfr.Location = new System.Drawing.Point(4, 450);
            this.blacklistfr.Name = "blacklistfr";
            this.blacklistfr.Size = new System.Drawing.Size(580, 16);
            this.blacklistfr.TabIndex = 22;
            this.blacklistfr.Text = "Besoin que votre compte/ip/email soit mis sur liste noire sur toutes les API. Con" +
    "tacter OldModz95.";
            // 
            // blacklisten
            // 
            this.blacklisten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blacklisten.AutoSize = true;
            this.blacklisten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklisten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.blacklisten.Location = new System.Drawing.Point(4, 431);
            this.blacklisten.Name = "blacklisten";
            this.blacklisten.Size = new System.Drawing.Size(467, 16);
            this.blacklisten.TabIndex = 23;
            this.blacklisten.Text = "Need that your account/ip/mail be blacklisted on all APIs. Contact OldModz95.";
            // 
            // captcha
            // 
            this.captcha.BackAlpha = 100;
            this.captcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.captcha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.captcha.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captcha.ForeColor = System.Drawing.Color.White;
            this.captcha.Location = new System.Drawing.Point(28, 260);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(254, 25);
            this.captcha.TabIndex = 24;
            this.captcha.Tag = "";
            this.captcha.Text = "Captcha";
            this.captcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoldResolver
            // 
            this.GoldResolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoldResolver.AutoSize = true;
            this.GoldResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldResolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.GoldResolver.Location = new System.Drawing.Point(213, 21);
            this.GoldResolver.Name = "GoldResolver";
            this.GoldResolver.Size = new System.Drawing.Size(250, 39);
            this.GoldResolver.TabIndex = 25;
            this.GoldResolver.Text = "Gold Resolver";
            // 
            // captchatimer
            // 
            this.captchatimer.Tick += new System.EventHandler(this.captchatimer_Tick);
            // 
            // captchaletter
            // 
            this.captchaletter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.captchaletter.AutoSize = true;
            this.captchaletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captchaletter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.captchaletter.Location = new System.Drawing.Point(25, 288);
            this.captchaletter.Name = "captchaletter";
            this.captchaletter.Size = new System.Drawing.Size(61, 16);
            this.captchaletter.TabIndex = 26;
            this.captchaletter.Text = "Captcha:";
            // 
            // labelcapcha
            // 
            this.labelcapcha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelcapcha.AutoSize = true;
            this.labelcapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelcapcha.Location = new System.Drawing.Point(85, 288);
            this.labelcapcha.Name = "labelcapcha";
            this.labelcapcha.Size = new System.Drawing.Size(61, 16);
            this.labelcapcha.TabIndex = 27;
            this.labelcapcha.Text = "Captcha:";
            // 
            // validecaptcha
            // 
            this.validecaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validecaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.validecaptcha.FlatAppearance.BorderSize = 0;
            this.validecaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validecaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validecaptcha.ForeColor = System.Drawing.Color.LightGray;
            this.validecaptcha.Location = new System.Drawing.Point(286, 260);
            this.validecaptcha.Name = "validecaptcha";
            this.validecaptcha.Size = new System.Drawing.Size(23, 25);
            this.validecaptcha.TabIndex = 28;
            this.validecaptcha.Text = "X";
            this.validecaptcha.UseVisualStyleBackColor = false;
            this.validecaptcha.Click += new System.EventHandler(this.button1_Click);
            // 
            // exe
            // 
            this.exe.AutoSize = true;
            this.exe.Location = new System.Drawing.Point(229, 650);
            this.exe.Name = "exe";
            this.exe.Size = new System.Drawing.Size(35, 13);
            this.exe.TabIndex = 29;
            this.exe.Text = "label3";
            // 
            // skypetoip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(700, 470);
            this.Controls.Add(this.exe);
            this.Controls.Add(this.validecaptcha);
            this.Controls.Add(this.labelcapcha);
            this.Controls.Add(this.captchaletter);
            this.Controls.Add(this.GoldResolver);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.blacklisten);
            this.Controls.Add(this.blacklistfr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.response);
            this.Controls.Add(this.skype);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "skypetoip";
            this.Text = "skypetoip";
            this.responseclic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private ZBobb.AlphaBlendTextBox skype;
		private System.Windows.Forms.Label label2;
		private ZBobb.AlphaBlendTextBox response;
		private System.Windows.Forms.Label blacklistfr;
		private System.Windows.Forms.Label blacklisten;
		private ZBobb.AlphaBlendTextBox captcha;
		private System.Windows.Forms.Label GoldResolver;
		private System.Windows.Forms.Timer captchatimer;
		private System.Windows.Forms.Label captchaletter;
		private System.Windows.Forms.Label labelcapcha;
		private System.Windows.Forms.Button validecaptcha;
		private theme.FlatContextMenuStrip responseclic;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.Label exe;
	}
}