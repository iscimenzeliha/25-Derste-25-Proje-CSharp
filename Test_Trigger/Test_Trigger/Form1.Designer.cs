namespace Test_Trigger
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TXTID = new System.Windows.Forms.TextBox();
			this.TXTAD = new System.Windows.Forms.TextBox();
			this.TXTYAZAR = new System.Windows.Forms.TextBox();
			this.TXTSAYFA = new System.Windows.Forms.TextBox();
			this.TXTYAYIN = new System.Windows.Forms.TextBox();
			this.TXTTUR = new System.Windows.Forms.TextBox();
			this.BTNEKLE = new System.Windows.Forms.Button();
			this.BTNSİL = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.LBLKITAP = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "AD:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "YAZAR:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "SAYFA:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "YAYINEVİ:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(50, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 19);
			this.label6.TabIndex = 5;
			this.label6.Text = "TUR:";
			// 
			// TXTID
			// 
			this.TXTID.Enabled = false;
			this.TXTID.Location = new System.Drawing.Point(98, 49);
			this.TXTID.Name = "TXTID";
			this.TXTID.Size = new System.Drawing.Size(157, 27);
			this.TXTID.TabIndex = 66;
			// 
			// TXTAD
			// 
			this.TXTAD.Location = new System.Drawing.Point(98, 82);
			this.TXTAD.Name = "TXTAD";
			this.TXTAD.Size = new System.Drawing.Size(157, 27);
			this.TXTAD.TabIndex = 1;
			// 
			// TXTYAZAR
			// 
			this.TXTYAZAR.Location = new System.Drawing.Point(98, 115);
			this.TXTYAZAR.Name = "TXTYAZAR";
			this.TXTYAZAR.Size = new System.Drawing.Size(157, 27);
			this.TXTYAZAR.TabIndex = 2;
			// 
			// TXTSAYFA
			// 
			this.TXTSAYFA.Location = new System.Drawing.Point(98, 148);
			this.TXTSAYFA.Name = "TXTSAYFA";
			this.TXTSAYFA.Size = new System.Drawing.Size(157, 27);
			this.TXTSAYFA.TabIndex = 3;
			// 
			// TXTYAYIN
			// 
			this.TXTYAYIN.Location = new System.Drawing.Point(98, 184);
			this.TXTYAYIN.Name = "TXTYAYIN";
			this.TXTYAYIN.Size = new System.Drawing.Size(157, 27);
			this.TXTYAYIN.TabIndex = 4;
			// 
			// TXTTUR
			// 
			this.TXTTUR.Location = new System.Drawing.Point(98, 217);
			this.TXTTUR.Name = "TXTTUR";
			this.TXTTUR.Size = new System.Drawing.Size(157, 27);
			this.TXTTUR.TabIndex = 5;
			// 
			// BTNEKLE
			// 
			this.BTNEKLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BTNEKLE.Location = new System.Drawing.Point(98, 250);
			this.BTNEKLE.Name = "BTNEKLE";
			this.BTNEKLE.Size = new System.Drawing.Size(73, 30);
			this.BTNEKLE.TabIndex = 12;
			this.BTNEKLE.Text = "EKLE";
			this.BTNEKLE.UseVisualStyleBackColor = false;
			this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
			// 
			// BTNSİL
			// 
			this.BTNSİL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.BTNSİL.Location = new System.Drawing.Point(182, 250);
			this.BTNSİL.Name = "BTNSİL";
			this.BTNSİL.Size = new System.Drawing.Size(73, 30);
			this.BTNSİL.TabIndex = 13;
			this.BTNSİL.Text = "SİL";
			this.BTNSİL.UseVisualStyleBackColor = false;
			this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TXTID);
			this.groupBox1.Controls.Add(this.BTNSİL);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BTNEKLE);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TXTTUR);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.TXTYAYIN);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.TXTSAYFA);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TXTYAZAR);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.TXTAD);
			this.groupBox1.Location = new System.Drawing.Point(12, -3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(287, 354);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(305, -3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(530, 307);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(524, 281);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.LBLKITAP);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(308, 307);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(527, 44);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 19);
			this.label7.TabIndex = 0;
			this.label7.Text = "KİTAP ADET:";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// LBLKITAP
			// 
			this.LBLKITAP.AutoSize = true;
			this.LBLKITAP.Location = new System.Drawing.Point(106, 17);
			this.LBLKITAP.Name = "LBLKITAP";
			this.LBLKITAP.Size = new System.Drawing.Size(17, 19);
			this.LBLKITAP.TabIndex = 1;
			this.LBLKITAP.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(838, 352);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TXTID;
		private System.Windows.Forms.TextBox TXTAD;
		private System.Windows.Forms.TextBox TXTYAZAR;
		private System.Windows.Forms.TextBox TXTSAYFA;
		private System.Windows.Forms.TextBox TXTYAYIN;
		private System.Windows.Forms.TextBox TXTTUR;
		private System.Windows.Forms.Button BTNEKLE;
		private System.Windows.Forms.Button BTNSİL;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label LBLKITAP;
	}
}

