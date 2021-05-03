namespace Gold_Resolver
{
	partial class paneldefaut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paneldefaut));
            this.welcome = new System.Windows.Forms.Label();
            this.status = new ZBobb.AlphaBlendTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new ZBobb.AlphaBlendTextBox();
            this.ytb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerstatus = new System.Windows.Forms.Timer(this.components);
            this.closewebsite = new System.Windows.Forms.Button();
            this.statusclic = new theme.FlatContextMenuStrip();
            this.reloadStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ytb)).BeginInit();
            this.statusclic.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Silver;
            this.welcome.Location = new System.Drawing.Point(197, 22);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(297, 120);
            this.welcome.TabIndex = 108;
            this.welcome.Text = "Welcome to\r\nGold Resolver";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.BackAlpha = 100;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status.ContextMenuStrip = this.statusclic;
            this.status.Cursor = System.Windows.Forms.Cursors.No;
            this.status.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(39, 309);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(254, 89);
            this.status.TabIndex = 104;
            this.status.Tag = "";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "[+] Status";
            // 
            // update
            // 
            this.update.BackAlpha = 100;
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.update.Cursor = System.Windows.Forms.Cursors.No;
            this.update.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(41, 236);
            this.update.Multiline = true;
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Size = new System.Drawing.Size(254, 41);
            this.update.TabIndex = 109;
            this.update.Tag = "";
            this.update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ytb
            // 
            this.ytb.Image = ((System.Drawing.Image)(resources.GetObject("ytb.Image")));
            this.ytb.Location = new System.Drawing.Point(336, 236);
            this.ytb.Name = "ytb";
            this.ytb.Size = new System.Drawing.Size(325, 162);
            this.ytb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ytb.TabIndex = 107;
            this.ytb.TabStop = false;
            this.ytb.Click += new System.EventHandler(this.ytb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 110;
            this.label3.Text = "[+] Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 106;
            this.label2.Text = "[+] Video";
            // 
            // timerstatus
            // 
            this.timerstatus.Tick += new System.EventHandler(this.timerstatus_Tick);
            // 
            // closewebsite
            // 
            this.closewebsite.FlatAppearance.BorderSize = 0;
            this.closewebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.closewebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closewebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closewebsite.ForeColor = System.Drawing.Color.LightGray;
            this.closewebsite.Location = new System.Drawing.Point(673, 2);
            this.closewebsite.Name = "closewebsite";
            this.closewebsite.Size = new System.Drawing.Size(25, 25);
            this.closewebsite.TabIndex = 111;
            this.closewebsite.Text = "X";
            this.closewebsite.UseVisualStyleBackColor = true;
            this.closewebsite.Click += new System.EventHandler(this.closewebsite_Click);
            // 
            // statusclic
            // 
            this.statusclic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.statusclic.ForeColor = System.Drawing.Color.White;
            this.statusclic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadStatusToolStripMenuItem});
            this.statusclic.Name = "statusclic";
            this.statusclic.ShowImageMargin = false;
            this.statusclic.Size = new System.Drawing.Size(121, 26);
            this.statusclic.Opening += new System.ComponentModel.CancelEventHandler(this.statusclic_Opening);
            // 
            // reloadStatusToolStripMenuItem
            // 
            this.reloadStatusToolStripMenuItem.Name = "reloadStatusToolStripMenuItem";
            this.reloadStatusToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reloadStatusToolStripMenuItem.Text = "Reload Status";
            // 
            // paneldefaut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(700, 470);
            this.Controls.Add(this.closewebsite);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.ytb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paneldefaut";
            this.Text = "paneldefaut";
            ((System.ComponentModel.ISupportInitialize)(this.ytb)).EndInit();
            this.statusclic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label welcome;
		private ZBobb.AlphaBlendTextBox status;
		private System.Windows.Forms.Label label1;
		private ZBobb.AlphaBlendTextBox update;
		private System.Windows.Forms.PictureBox ytb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timerstatus;
		private System.Windows.Forms.Button closewebsite;
		private theme.FlatContextMenuStrip statusclic;
		private System.Windows.Forms.ToolStripMenuItem reloadStatusToolStripMenuItem;
	}
}