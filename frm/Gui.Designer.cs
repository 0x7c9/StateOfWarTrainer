namespace StateOfWarTrainer.frm
{
	partial class Gui
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.blbTitle = new System.Windows.Forms.Label();
			this.lblMoney = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMoney);
			this.groupBox1.Controls.Add(this.lblMoney);
			this.groupBox1.Location = new System.Drawing.Point(16, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(318, 51);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// blbTitle
			// 
			this.blbTitle.AutoSize = true;
			this.blbTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.blbTitle.ForeColor = System.Drawing.Color.Black;
			this.blbTitle.Location = new System.Drawing.Point(13, 24);
			this.blbTitle.Name = "blbTitle";
			this.blbTitle.Size = new System.Drawing.Size(297, 19);
			this.blbTitle.TabIndex = 1;
			this.blbTitle.Text = "State Of War Warmonger - Trainer";
			// 
			// lblMoney
			// 
			this.lblMoney.AutoSize = true;
			this.lblMoney.Location = new System.Drawing.Point(7, 20);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(43, 13);
			this.lblMoney.TabIndex = 0;
			this.lblMoney.Text = "Money:";
			// 
			// txtMoney
			// 
			this.txtMoney.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtMoney.Location = new System.Drawing.Point(56, 17);
			this.txtMoney.MaxLength = 5;
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(106, 20);
			this.txtMoney.TabIndex = 1;
			this.txtMoney.TextChanged += new System.EventHandler(this.MoneyChanged);
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(346, 24);
			this.menu.TabIndex = 2;
			this.menu.Text = "menuStrip1";
			// 
			// btnAbout
			// 
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(58, 20);
			this.btnAbout.Text = "About..";
			this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
			// 
			// Gui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 113);
			this.Controls.Add(this.blbTitle);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menu);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.MaximizeBox = false;
			this.Name = "Gui";
			this.Text = "Gui";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.Label lblMoney;
		private System.Windows.Forms.Label blbTitle;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem btnAbout;
	}
}