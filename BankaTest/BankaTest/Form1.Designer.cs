﻿namespace BankaTest
{
	partial class Form1
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
			this.MSKHESAP = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TXTSİFRE = new System.Windows.Forms.TextBox();
			this.BTNGİRİS = new System.Windows.Forms.Button();
			this.LNKKAYIT = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// MSKHESAP
			// 
			this.MSKHESAP.Location = new System.Drawing.Point(197, 90);
			this.MSKHESAP.Mask = "000000";
			this.MSKHESAP.Name = "MSKHESAP";
			this.MSKHESAP.Size = new System.Drawing.Size(122, 27);
			this.MSKHESAP.TabIndex = 1;
			this.MSKHESAP.ValidatingType = typeof(int);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "HESAP NO:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "ŞİFRE:";
			// 
			// TXTSİFRE
			// 
			this.TXTSİFRE.Location = new System.Drawing.Point(197, 141);
			this.TXTSİFRE.Name = "TXTSİFRE";
			this.TXTSİFRE.Size = new System.Drawing.Size(122, 27);
			this.TXTSİFRE.TabIndex = 2;
			this.TXTSİFRE.UseSystemPasswordChar = true;
			// 
			// BTNGİRİS
			// 
			this.BTNGİRİS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BTNGİRİS.Location = new System.Drawing.Point(197, 191);
			this.BTNGİRİS.Name = "BTNGİRİS";
			this.BTNGİRİS.Size = new System.Drawing.Size(122, 29);
			this.BTNGİRİS.TabIndex = 3;
			this.BTNGİRİS.Text = "GİRİŞ YAP";
			this.BTNGİRİS.UseVisualStyleBackColor = false;
			this.BTNGİRİS.Click += new System.EventHandler(this.BTNGİRİS_Click);
			// 
			// LNKKAYIT
			// 
			this.LNKKAYIT.AutoSize = true;
			this.LNKKAYIT.Location = new System.Drawing.Point(355, 129);
			this.LNKKAYIT.Name = "LNKKAYIT";
			this.LNKKAYIT.Size = new System.Drawing.Size(73, 19);
			this.LNKKAYIT.TabIndex = 4;
			this.LNKKAYIT.TabStop = true;
			this.LNKKAYIT.Text = "KAYIT OL";
			this.LNKKAYIT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNKKAYIT_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(449, 268);
			this.Controls.Add(this.LNKKAYIT);
			this.Controls.Add(this.BTNGİRİS);
			this.Controls.Add(this.TXTSİFRE);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MSKHESAP);
			this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox MSKHESAP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TXTSİFRE;
		private System.Windows.Forms.Button BTNGİRİS;
		private System.Windows.Forms.LinkLabel LNKKAYIT;
	}
}

