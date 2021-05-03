namespace Gold_Resolver
{
	partial class emailchecker
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
            this.responseclic = new theme.FlatContextMenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test = new System.Windows.Forms.Timer(this.components);
            this.exe = new System.Windows.Forms.Label();
            this.validecaptcha = new System.Windows.Forms.Button();
            this.labelcapcha = new System.Windows.Forms.Label();
            this.captchaletter = new System.Windows.Forms.Label();
            this.GoldResolver = new System.Windows.Forms.Label();
            this.captcha = new ZBobb.AlphaBlendTextBox();
            this.blacklisten = new System.Windows.Forms.Label();
            this.blacklistfr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.response = new ZBobb.AlphaBlendTextBox();
            this.skype = new ZBobb.AlphaBlendTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.responseclic.SuspendLayout();
            this.SuspendLayout();
            // 
            // responseclic
            // 
            this.responseclic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.responseclic.ForeColor = System.Drawing.Color.White;
            this.responseclic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.responseclic.Name = "responseclic";
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
            // exe
            // 
            this.exe.AutoSize = true;
            this.exe.Location = new System.Drawing.Point(640, 415);
            this.exe.Name = "exe";
            this.exe.Size = new System.Drawing.Size(24, 13);
            this.exe.TabIndex = 112;
            this.exe.Text = "exe";
            this.exe.Visible = false;
            // 
            // validecaptcha
            // 
            this.validecaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validecaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.validecaptcha.FlatAppearance.BorderSize = 0;
            this.validecaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validecaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validecaptcha.ForeColor = System.Drawing.Color.LightGray;
            this.validecaptcha.Location = new System.Drawing.Point(284, 263);
            this.validecaptcha.Name = "validecaptcha";
            this.validecaptcha.Size = new System.Drawing.Size(23, 25);
            this.validecaptcha.TabIndex = 111;
            this.validecaptcha.Text = "X";
            this.validecaptcha.UseVisualStyleBackColor = false;
            this.validecaptcha.Click += new System.EventHandler(this.validecaptcha_Click);
            // 
            // labelcapcha
            // 
            this.labelcapcha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelcapcha.AutoSize = true;
            this.labelcapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelcapcha.Location = new System.Drawing.Point(83, 291);
            this.labelcapcha.Name = "labelcapcha";
            this.labelcapcha.Size = new System.Drawing.Size(61, 16);
            this.labelcapcha.TabIndex = 110;
            this.labelcapcha.Text = "Captcha:";
            // 
            // captchaletter
            // 
            this.captchaletter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.captchaletter.AutoSize = true;
            this.captchaletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captchaletter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.captchaletter.Location = new System.Drawing.Point(23, 291);
            this.captchaletter.Name = "captchaletter";
            this.captchaletter.Size = new System.Drawing.Size(61, 16);
            this.captchaletter.TabIndex = 109;
            this.captchaletter.Text = "Captcha:";
            // 
            // GoldResolver
            // 
            this.GoldResolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoldResolver.AutoSize = true;
            this.GoldResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldResolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.GoldResolver.Location = new System.Drawing.Point(211, 24);
            this.GoldResolver.Name = "GoldResolver";
            this.GoldResolver.Size = new System.Drawing.Size(250, 39);
            this.GoldResolver.TabIndex = 108;
            this.GoldResolver.Text = "Gold Resolver";
            // 
            // captcha
            // 
            this.captcha.BackAlpha = 100;
            this.captcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.captcha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.captcha.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captcha.ForeColor = System.Drawing.Color.White;
            this.captcha.Location = new System.Drawing.Point(26, 263);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(254, 25);
            this.captcha.TabIndex = 107;
            this.captcha.Tag = "";
            this.captcha.Text = "Captcha";
            this.captcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blacklisten
            // 
            this.blacklisten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blacklisten.AutoSize = true;
            this.blacklisten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklisten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.blacklisten.Location = new System.Drawing.Point(2, 434);
            this.blacklisten.Name = "blacklisten";
            this.blacklisten.Size = new System.Drawing.Size(467, 16);
            this.blacklisten.TabIndex = 106;
            this.blacklisten.Text = "Need that your account/ip/mail be blacklisted on all APIs. Contact OldModz95.";
            // 
            // blacklistfr
            // 
            this.blacklistfr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blacklistfr.AutoSize = true;
            this.blacklistfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistfr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.blacklistfr.Location = new System.Drawing.Point(2, 453);
            this.blacklistfr.Name = "blacklistfr";
            this.blacklistfr.Size = new System.Drawing.Size(580, 16);
            this.blacklistfr.TabIndex = 105;
            this.blacklistfr.Text = "Besoin que votre compte/ip/email soit mis sur liste noire sur toutes les API. Con" +
    "tacter OldModz95.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 104;
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
            this.response.Location = new System.Drawing.Point(345, 129);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.ReadOnly = true;
            this.response.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.response.Size = new System.Drawing.Size(324, 254);
            this.response.TabIndex = 103;
            this.response.Tag = "";
            this.response.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // skype
            // 
            this.skype.BackAlpha = 100;
            this.skype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skype.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skype.ForeColor = System.Drawing.Color.White;
            this.skype.Location = new System.Drawing.Point(26, 222);
            this.skype.Name = "skype";
            this.skype.Size = new System.Drawing.Size(254, 23);
            this.skype.TabIndex = 102;
            this.skype.Tag = "";
            this.skype.Text = "test@yopmail.com";
            this.skype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(674, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 101;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(26, 339);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(254, 32);
            this.button9.TabIndex = 100;
            this.button9.Text = "Resolve Mail";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(30, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 99;
            this.label1.Text = "Email Checker";
            // 
            // emailchecker
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
            this.Name = "emailchecker";
            this.Text = "emailchecker";
            this.responseclic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private theme.FlatContextMenuStrip responseclic;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.Timer test;
		private System.Windows.Forms.Label exe;
		private System.Windows.Forms.Button validecaptcha;
		private System.Windows.Forms.Label labelcapcha;
		private System.Windows.Forms.Label captchaletter;
		private System.Windows.Forms.Label GoldResolver;
		private ZBobb.AlphaBlendTextBox captcha;
		private System.Windows.Forms.Label blacklisten;
		private System.Windows.Forms.Label blacklistfr;
		private System.Windows.Forms.Label label2;
		private ZBobb.AlphaBlendTextBox response;
		private ZBobb.AlphaBlendTextBox skype;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label1;
	}
}