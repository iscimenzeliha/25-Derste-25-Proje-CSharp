namespace BankaTest
{
	partial class Form3
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BTNKAYDET = new System.Windows.Forms.Button();
			this.TXTAD = new System.Windows.Forms.TextBox();
			this.MSKTC = new System.Windows.Forms.MaskedTextBox();
			this.MSKTEL = new System.Windows.Forms.MaskedTextBox();
			this.TXTSOYAD = new System.Windows.Forms.TextBox();
			this.MSKHESAP = new System.Windows.Forms.MaskedTextBox();
			this.TXTSİFRE = new System.Windows.Forms.TextBox();
			this.BTNHESAPNO = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "TC KİMLİK:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "TELEFON:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "AD:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 212);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "ŞİFRE:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 19);
			this.label6.TabIndex = 8;
			this.label6.Text = "HESAP NO:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(45, 57);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 19);
			this.label7.TabIndex = 10;
			this.label7.Text = " SOYAD:";
			// 
			// BTNKAYDET
			// 
			this.BTNKAYDET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BTNKAYDET.Location = new System.Drawing.Point(118, 248);
			this.BTNKAYDET.Name = "BTNKAYDET";
			this.BTNKAYDET.Size = new System.Drawing.Size(122, 28);
			this.BTNKAYDET.TabIndex = 7;
			this.BTNKAYDET.Text = "KAYDET";
			this.BTNKAYDET.UseVisualStyleBackColor = false;
			this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
			// 
			// TXTAD
			// 
			this.TXTAD.Location = new System.Drawing.Point(118, 20);
			this.TXTAD.Name = "TXTAD";
			this.TXTAD.Size = new System.Drawing.Size(122, 27);
			this.TXTAD.TabIndex = 1;
			// 
			// MSKTC
			// 
			this.MSKTC.Location = new System.Drawing.Point(118, 91);
			this.MSKTC.Mask = "00000000000";
			this.MSKTC.Name = "MSKTC";
			this.MSKTC.Size = new System.Drawing.Size(122, 27);
			this.MSKTC.TabIndex = 3;
			this.MSKTC.ValidatingType = typeof(int);
			// 
			// MSKTEL
			// 
			this.MSKTEL.Location = new System.Drawing.Point(118, 132);
			this.MSKTEL.Mask = "(999) 000-0000";
			this.MSKTEL.Name = "MSKTEL";
			this.MSKTEL.Size = new System.Drawing.Size(122, 27);
			this.MSKTEL.TabIndex = 4;
			// 
			// TXTSOYAD
			// 
			this.TXTSOYAD.Location = new System.Drawing.Point(118, 57);
			this.TXTSOYAD.Name = "TXTSOYAD";
			this.TXTSOYAD.Size = new System.Drawing.Size(122, 27);
			this.TXTSOYAD.TabIndex = 2;
			// 
			// MSKHESAP
			// 
			this.MSKHESAP.Enabled = false;
			this.MSKHESAP.Location = new System.Drawing.Point(118, 173);
			this.MSKHESAP.Mask = "000000";
			this.MSKHESAP.Name = "MSKHESAP";
			this.MSKHESAP.Size = new System.Drawing.Size(122, 27);
			this.MSKHESAP.TabIndex = 5;
			this.MSKHESAP.ValidatingType = typeof(int);
			// 
			// TXTSİFRE
			// 
			this.TXTSİFRE.Location = new System.Drawing.Point(118, 212);
			this.TXTSİFRE.Name = "TXTSİFRE";
			this.TXTSİFRE.Size = new System.Drawing.Size(122, 27);
			this.TXTSİFRE.TabIndex = 6;
			// 
			// BTNHESAPNO
			// 
			this.BTNHESAPNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BTNHESAPNO.Location = new System.Drawing.Point(252, 173);
			this.BTNHESAPNO.Name = "BTNHESAPNO";
			this.BTNHESAPNO.Size = new System.Drawing.Size(29, 28);
			this.BTNHESAPNO.TabIndex = 21;
			this.BTNHESAPNO.Text = "...";
			this.BTNHESAPNO.UseVisualStyleBackColor = false;
			this.BTNHESAPNO.Click += new System.EventHandler(this.BTNHESAPNO_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(293, 334);
			this.Controls.Add(this.BTNHESAPNO);
			this.Controls.Add(this.TXTSİFRE);
			this.Controls.Add(this.MSKHESAP);
			this.Controls.Add(this.TXTSOYAD);
			this.Controls.Add(this.MSKTEL);
			this.Controls.Add(this.BTNKAYDET);
			this.Controls.Add(this.TXTAD);
			this.Controls.Add(this.MSKTC);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BTNKAYDET;
		private System.Windows.Forms.TextBox TXTAD;
		private System.Windows.Forms.MaskedTextBox MSKTC;
		private System.Windows.Forms.MaskedTextBox MSKTEL;
		private System.Windows.Forms.TextBox TXTSOYAD;
		private System.Windows.Forms.MaskedTextBox MSKHESAP;
		private System.Windows.Forms.TextBox TXTSİFRE;
		private System.Windows.Forms.Button BTNHESAPNO;
	}
}