namespace Resim_
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
			this.btnrenk = new System.Windows.Forms.Button();
			this.btnresım = new System.Windows.Forms.Button();
			this.btnyazdır = new System.Windows.Forms.Button();
			this.btnkaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtmetın = new System.Windows.Forms.TextBox();
			this.txtboyut = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnrenk
			// 
			this.btnrenk.Location = new System.Drawing.Point(38, 47);
			this.btnrenk.Name = "btnrenk";
			this.btnrenk.Size = new System.Drawing.Size(159, 45);
			this.btnrenk.TabIndex = 0;
			this.btnrenk.Text = "Renk Seç";
			this.btnrenk.UseVisualStyleBackColor = true;
			this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
			// 
			// btnresım
			// 
			this.btnresım.Location = new System.Drawing.Point(38, 106);
			this.btnresım.Name = "btnresım";
			this.btnresım.Size = new System.Drawing.Size(159, 45);
			this.btnresım.TabIndex = 1;
			this.btnresım.Text = "Resim Seç";
			this.btnresım.UseVisualStyleBackColor = true;
			this.btnresım.Click += new System.EventHandler(this.btnresım_Click);
			// 
			// btnyazdır
			// 
			this.btnyazdır.Location = new System.Drawing.Point(38, 167);
			this.btnyazdır.Name = "btnyazdır";
			this.btnyazdır.Size = new System.Drawing.Size(159, 45);
			this.btnyazdır.TabIndex = 2;
			this.btnyazdır.Text = "Yazdır";
			this.btnyazdır.UseVisualStyleBackColor = true;
			this.btnyazdır.Click += new System.EventHandler(this.btnyazdır_Click);
			// 
			// btnkaydet
			// 
			this.btnkaydet.Location = new System.Drawing.Point(38, 227);
			this.btnkaydet.Name = "btnkaydet";
			this.btnkaydet.Size = new System.Drawing.Size(159, 45);
			this.btnkaydet.TabIndex = 3;
			this.btnkaydet.Text = "Kaydet";
			this.btnkaydet.UseVisualStyleBackColor = true;
			this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Metin:";
			// 
			// txtmetın
			// 
			this.txtmetın.Location = new System.Drawing.Point(82, 302);
			this.txtmetın.Name = "txtmetın";
			this.txtmetın.Size = new System.Drawing.Size(115, 27);
			this.txtmetın.TabIndex = 5;
			// 
			// txtboyut
			// 
			this.txtboyut.Location = new System.Drawing.Point(82, 346);
			this.txtboyut.Name = "txtboyut";
			this.txtboyut.Size = new System.Drawing.Size(115, 27);
			this.txtboyut.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 346);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Boyut:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(229, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(576, 331);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnkaydet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 400);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtboyut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtmetın);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnkaydet);
			this.Controls.Add(this.btnyazdır);
			this.Controls.Add(this.btnresım);
			this.Controls.Add(this.btnrenk);
			this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnrenk;
		private System.Windows.Forms.Button btnresım;
		private System.Windows.Forms.Button btnyazdır;
		private System.Windows.Forms.Button btnkaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtmetın;
		private System.Windows.Forms.TextBox txtboyut;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}

