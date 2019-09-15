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
			this.txtFighters = new System.Windows.Forms.TextBox();
			this.lblFighters = new System.Windows.Forms.Label();
			this.txtTroopers = new System.Windows.Forms.TextBox();
			this.lblTroopers = new System.Windows.Forms.Label();
			this.txtTrojans = new System.Windows.Forms.TextBox();
			this.lblTrojans = new System.Windows.Forms.Label();
			this.txtBombarders = new System.Windows.Forms.TextBox();
			this.lblBombarders = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.lblMoney = new System.Windows.Forms.Label();
			this.blbTitle = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.txtResearch = new System.Windows.Forms.TextBox();
			this.lblResearch = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.lblTipFreeze = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTipFreeze);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.txtResearch);
			this.groupBox1.Controls.Add(this.lblResearch);
			this.groupBox1.Controls.Add(this.txtFighters);
			this.groupBox1.Controls.Add(this.lblFighters);
			this.groupBox1.Controls.Add(this.txtTroopers);
			this.groupBox1.Controls.Add(this.lblTroopers);
			this.groupBox1.Controls.Add(this.txtTrojans);
			this.groupBox1.Controls.Add(this.lblTrojans);
			this.groupBox1.Controls.Add(this.txtBombarders);
			this.groupBox1.Controls.Add(this.lblBombarders);
			this.groupBox1.Controls.Add(this.txtMoney);
			this.groupBox1.Controls.Add(this.lblMoney);
			this.groupBox1.Location = new System.Drawing.Point(16, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(318, 234);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "s";
			// 
			// txtFighters
			// 
			this.txtFighters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtFighters.ForeColor = System.Drawing.Color.Blue;
			this.txtFighters.Location = new System.Drawing.Point(205, 129);
			this.txtFighters.MaxLength = 5;
			this.txtFighters.Name = "txtFighters";
			this.txtFighters.Size = new System.Drawing.Size(106, 20);
			this.txtFighters.TabIndex = 9;
			this.txtFighters.TextChanged += new System.EventHandler(this.FightersChanged);
			// 
			// lblFighters
			// 
			this.lblFighters.AutoSize = true;
			this.lblFighters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblFighters.Location = new System.Drawing.Point(7, 132);
			this.lblFighters.Name = "lblFighters";
			this.lblFighters.Size = new System.Drawing.Size(61, 13);
			this.lblFighters.TabIndex = 8;
			this.lblFighters.Text = "Fighters:";
			// 
			// txtTroopers
			// 
			this.txtTroopers.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtTroopers.ForeColor = System.Drawing.Color.Blue;
			this.txtTroopers.Location = new System.Drawing.Point(206, 100);
			this.txtTroopers.MaxLength = 5;
			this.txtTroopers.Name = "txtTroopers";
			this.txtTroopers.Size = new System.Drawing.Size(106, 20);
			this.txtTroopers.TabIndex = 7;
			this.txtTroopers.TextChanged += new System.EventHandler(this.TroopersChanged);
			// 
			// lblTroopers
			// 
			this.lblTroopers.AutoSize = true;
			this.lblTroopers.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTroopers.Location = new System.Drawing.Point(7, 103);
			this.lblTroopers.Name = "lblTroopers";
			this.lblTroopers.Size = new System.Drawing.Size(61, 13);
			this.lblTroopers.TabIndex = 6;
			this.lblTroopers.Text = "Troopers:";
			// 
			// txtTrojans
			// 
			this.txtTrojans.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtTrojans.ForeColor = System.Drawing.Color.Blue;
			this.txtTrojans.Location = new System.Drawing.Point(206, 74);
			this.txtTrojans.MaxLength = 5;
			this.txtTrojans.Name = "txtTrojans";
			this.txtTrojans.Size = new System.Drawing.Size(106, 20);
			this.txtTrojans.TabIndex = 5;
			this.txtTrojans.TextChanged += new System.EventHandler(this.TrojansChanged);
			// 
			// lblTrojans
			// 
			this.lblTrojans.AutoSize = true;
			this.lblTrojans.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTrojans.Location = new System.Drawing.Point(7, 77);
			this.lblTrojans.Name = "lblTrojans";
			this.lblTrojans.Size = new System.Drawing.Size(55, 13);
			this.lblTrojans.TabIndex = 4;
			this.lblTrojans.Text = "Trojans:";
			// 
			// txtBombarders
			// 
			this.txtBombarders.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtBombarders.ForeColor = System.Drawing.Color.Blue;
			this.txtBombarders.Location = new System.Drawing.Point(206, 48);
			this.txtBombarders.MaxLength = 5;
			this.txtBombarders.Name = "txtBombarders";
			this.txtBombarders.Size = new System.Drawing.Size(106, 20);
			this.txtBombarders.TabIndex = 3;
			this.txtBombarders.TextChanged += new System.EventHandler(this.BombardersChanged);
			// 
			// lblBombarders
			// 
			this.lblBombarders.AutoSize = true;
			this.lblBombarders.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblBombarders.Location = new System.Drawing.Point(7, 51);
			this.lblBombarders.Name = "lblBombarders";
			this.lblBombarders.Size = new System.Drawing.Size(73, 13);
			this.lblBombarders.TabIndex = 2;
			this.lblBombarders.Text = "Bombarders:";
			// 
			// txtMoney
			// 
			this.txtMoney.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtMoney.ForeColor = System.Drawing.Color.Blue;
			this.txtMoney.Location = new System.Drawing.Point(206, 19);
			this.txtMoney.MaxLength = 5;
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(106, 20);
			this.txtMoney.TabIndex = 1;
			this.txtMoney.TextChanged += new System.EventHandler(this.MoneyChanged);
			// 
			// lblMoney
			// 
			this.lblMoney.AutoSize = true;
			this.lblMoney.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblMoney.Location = new System.Drawing.Point(7, 22);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(43, 13);
			this.lblMoney.TabIndex = 0;
			this.lblMoney.Text = "Money:";
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
			// txtResearch
			// 
			this.txtResearch.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtResearch.ForeColor = System.Drawing.Color.Blue;
			this.txtResearch.Location = new System.Drawing.Point(205, 155);
			this.txtResearch.MaxLength = 5;
			this.txtResearch.Name = "txtResearch";
			this.txtResearch.Size = new System.Drawing.Size(106, 20);
			this.txtResearch.TabIndex = 11;
			this.txtResearch.TextChanged += new System.EventHandler(this.ResearchChanged);
			// 
			// lblResearch
			// 
			this.lblResearch.AutoSize = true;
			this.lblResearch.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblResearch.Location = new System.Drawing.Point(7, 158);
			this.lblResearch.Name = "lblResearch";
			this.lblResearch.Size = new System.Drawing.Size(61, 13);
			this.lblResearch.TabIndex = 10;
			this.lblResearch.Text = "Research:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(10, 187);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(110, 17);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Freeze values!";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.FreezeValuesChanged);
			// 
			// lblTipFreeze
			// 
			this.lblTipFreeze.AutoSize = true;
			this.lblTipFreeze.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTipFreeze.Location = new System.Drawing.Point(7, 207);
			this.lblTipFreeze.Name = "lblTipFreeze";
			this.lblTipFreeze.Size = new System.Drawing.Size(253, 13);
			this.lblTipFreeze.TabIndex = 13;
			this.lblTipFreeze.Text = "*This choice can keep values from change.";
			// 
			// Gui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 291);
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
		private System.Windows.Forms.TextBox txtTroopers;
		private System.Windows.Forms.Label lblTroopers;
		private System.Windows.Forms.TextBox txtTrojans;
		private System.Windows.Forms.Label lblTrojans;
		private System.Windows.Forms.TextBox txtBombarders;
		private System.Windows.Forms.Label lblBombarders;
		private System.Windows.Forms.TextBox txtFighters;
		private System.Windows.Forms.Label lblFighters;
		private System.Windows.Forms.TextBox txtResearch;
		private System.Windows.Forms.Label lblResearch;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label lblTipFreeze;
	}
}