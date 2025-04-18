namespace BankaTest
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbladsoyad = new System.Windows.Forms.Label();
			this.lblhesap = new System.Windows.Forms.Label();
			this.lbltel = new System.Windows.Forms.Label();
			this.lbltc = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.TXTTUTAR = new System.Windows.Forms.TextBox();
			this.MSKHESAP = new System.Windows.Forms.MaskedTextBox();
			this.BTNGONDER = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "AD SOYAD:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "HESAP NO:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "TELEFON:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "TC KİMLİK:";
			// 
			// lbladsoyad
			// 
			this.lbladsoyad.AutoSize = true;
			this.lbladsoyad.Location = new System.Drawing.Point(141, 33);
			this.lbladsoyad.Name = "lbladsoyad";
			this.lbladsoyad.Size = new System.Drawing.Size(47, 19);
			this.lbladsoyad.TabIndex = 4;
			this.lbladsoyad.Text = "NULL";
			// 
			// lblhesap
			// 
			this.lblhesap.AutoSize = true;
			this.lblhesap.Location = new System.Drawing.Point(141, 66);
			this.lblhesap.Name = "lblhesap";
			this.lblhesap.Size = new System.Drawing.Size(47, 19);
			this.lblhesap.TabIndex = 5;
			this.lblhesap.Text = "NULL";
			// 
			// lbltel
			// 
			this.lbltel.AutoSize = true;
			this.lbltel.Location = new System.Drawing.Point(141, 97);
			this.lbltel.Name = "lbltel";
			this.lbltel.Size = new System.Drawing.Size(47, 19);
			this.lbltel.TabIndex = 6;
			this.lbltel.Text = "NULL";
			// 
			// lbltc
			// 
			this.lbltc.AutoSize = true;
			this.lbltc.Location = new System.Drawing.Point(141, 132);
			this.lbltc.Name = "lbltc";
			this.lbltc.Size = new System.Drawing.Size(47, 19);
			this.lbltc.TabIndex = 7;
			this.lbltc.Text = "NULL";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BTNGONDER);
			this.groupBox1.Controls.Add(this.TXTTUTAR);
			this.groupBox1.Controls.Add(this.MSKHESAP);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Location = new System.Drawing.Point(12, 230);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 194);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "HAVALE";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 19);
			this.label9.TabIndex = 9;
			this.label9.Text = "HESAP NO:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(22, 106);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 19);
			this.label10.TabIndex = 10;
			this.label10.Text = "TUTAR:";
			// 
			// TXTTUTAR
			// 
			this.TXTTUTAR.Location = new System.Drawing.Point(123, 106);
			this.TXTTUTAR.Name = "TXTTUTAR";
			this.TXTTUTAR.Size = new System.Drawing.Size(122, 27);
			this.TXTTUTAR.TabIndex = 12;
			// 
			// MSKHESAP
			// 
			this.MSKHESAP.Location = new System.Drawing.Point(123, 55);
			this.MSKHESAP.Mask = "000000";
			this.MSKHESAP.Name = "MSKHESAP";
			this.MSKHESAP.Size = new System.Drawing.Size(122, 27);
			this.MSKHESAP.TabIndex = 11;
			this.MSKHESAP.ValidatingType = typeof(int);
			// 
			// BTNGONDER
			// 
			this.BTNGONDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BTNGONDER.Location = new System.Drawing.Point(123, 139);
			this.BTNGONDER.Name = "BTNGONDER";
			this.BTNGONDER.Size = new System.Drawing.Size(122, 28);
			this.BTNGONDER.TabIndex = 13;
			this.BTNGONDER.Text = "GÖNDER";
			this.BTNGONDER.UseVisualStyleBackColor = false;
			this.BTNGONDER.Click += new System.EventHandler(this.BTNGONDER_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(544, 436);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbltc);
			this.Controls.Add(this.lbltel);
			this.Controls.Add(this.lblhesap);
			this.Controls.Add(this.lbladsoyad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbladsoyad;
		private System.Windows.Forms.Label lblhesap;
		private System.Windows.Forms.Label lbltel;
		private System.Windows.Forms.Label lbltc;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button BTNGONDER;
		private System.Windows.Forms.TextBox TXTTUTAR;
		private System.Windows.Forms.MaskedTextBox MSKHESAP;
	}
}