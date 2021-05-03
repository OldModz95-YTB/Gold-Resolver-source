namespace Gold_Resolver
{
	partial class questionform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questionform));
            this.fr = new System.Windows.Forms.PictureBox();
            this.usa = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.questionfrusa = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.sendquestion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usa)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // fr
            // 
            this.fr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fr.Image = ((System.Drawing.Image)(resources.GetObject("fr.Image")));
            this.fr.Location = new System.Drawing.Point(240, 13);
            this.fr.Name = "fr";
            this.fr.Size = new System.Drawing.Size(100, 50);
            this.fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fr.TabIndex = 105;
            this.fr.TabStop = false;
            this.fr.Visible = false;
            this.fr.Click += new System.EventHandler(this.fr_Click);
            // 
            // usa
            // 
            this.usa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usa.Image = ((System.Drawing.Image)(resources.GetObject("usa.Image")));
            this.usa.Location = new System.Drawing.Point(368, 13);
            this.usa.Name = "usa";
            this.usa.Size = new System.Drawing.Size(100, 50);
            this.usa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usa.TabIndex = 106;
            this.usa.TabStop = false;
            this.usa.Visible = false;
            this.usa.Click += new System.EventHandler(this.usa_Click);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.questionfrusa);
            this.panel7.Location = new System.Drawing.Point(12, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(689, 397);
            this.panel7.TabIndex = 107;
            // 
            // questionfrusa
            // 
            this.questionfrusa.AutoSize = true;
            this.questionfrusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionfrusa.ForeColor = System.Drawing.Color.Silver;
            this.questionfrusa.Location = new System.Drawing.Point(23, 8);
            this.questionfrusa.Name = "questionfrusa";
            this.questionfrusa.Size = new System.Drawing.Size(563, 740);
            this.questionfrusa.TabIndex = 0;
            this.questionfrusa.Text = resources.GetString("questionfrusa.Text");
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(675, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 108;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sendquestion
            // 
            this.sendquestion.Tick += new System.EventHandler(this.sendquestion_Tick);
            // 
            // questionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(700, 470);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fr);
            this.Controls.Add(this.usa);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "questionform";
            this.Text = "questionform";
            ((System.ComponentModel.ISupportInitialize)(this.fr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usa)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox fr;
		private System.Windows.Forms.PictureBox usa;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label questionfrusa;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Timer sendquestion;
	}
}