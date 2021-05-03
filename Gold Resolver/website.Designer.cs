namespace Gold_Resolver
{
	partial class website
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
            this.web = new System.Windows.Forms.WebBrowser();
            this.websitepanel = new System.Windows.Forms.Panel();
            this.closewebsite = new System.Windows.Forms.Button();
            this.oldmodz = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.websitepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(1, 33);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1102, 700);
            this.web.TabIndex = 0;
            // 
            // websitepanel
            // 
            this.websitepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.websitepanel.Controls.Add(this.closewebsite);
            this.websitepanel.Location = new System.Drawing.Point(-1, -1);
            this.websitepanel.Name = "websitepanel";
            this.websitepanel.Size = new System.Drawing.Size(1103, 33);
            this.websitepanel.TabIndex = 7;
            // 
            // closewebsite
            // 
            this.closewebsite.FlatAppearance.BorderSize = 0;
            this.closewebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.closewebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closewebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closewebsite.ForeColor = System.Drawing.Color.LightGray;
            this.closewebsite.Location = new System.Drawing.Point(5, 3);
            this.closewebsite.Name = "closewebsite";
            this.closewebsite.Size = new System.Drawing.Size(25, 25);
            this.closewebsite.TabIndex = 103;
            this.closewebsite.Text = "X";
            this.closewebsite.UseVisualStyleBackColor = true;
            this.closewebsite.Visible = false;
            this.closewebsite.Click += new System.EventHandler(this.closewebsite_Click);
            // 
            // oldmodz
            // 
            this.oldmodz.Fixed = true;
            this.oldmodz.Horizontal = true;
            this.oldmodz.TargetControl = this.websitepanel;
            this.oldmodz.Vertical = true;
            // 
            // website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 722);
            this.Controls.Add(this.websitepanel);
            this.Controls.Add(this.web);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "website";
            this.Text = "website";
            this.Load += new System.EventHandler(this.website_Load);
            this.websitepanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser web;
		private System.Windows.Forms.Panel websitepanel;
		private System.Windows.Forms.Button closewebsite;
		private Bunifu.Framework.UI.BunifuDragControl oldmodz;
	}
}