namespace Rehber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.MSKTEL = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.TXTSOYAD = new System.Windows.Forms.TextBox();
            this.TXTMAIL = new System.Windows.Forms.TextBox();
            this.BTNSİL = new System.Windows.Forms.Button();
            this.BTNGUNCELLE = new System.Windows.Forms.Button();
            this.BTNTEMIZLE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 375);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REHBER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNTEMIZLE);
            this.groupBox2.Controls.Add(this.BTNGUNCELLE);
            this.groupBox2.Controls.Add(this.BTNSİL);
            this.groupBox2.Controls.Add(this.TXTMAIL);
            this.groupBox2.Controls.Add(this.TXTSOYAD);
            this.groupBox2.Controls.Add(this.TXTAD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.MSKTEL);
            this.groupBox2.Controls.Add(this.TXTID);
            this.groupBox2.Controls.Add(this.BTNEKLE);
            this.groupBox2.Location = new System.Drawing.Point(566, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 375);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YENİ KİŞİ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 350);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Location = new System.Drawing.Point(41, 255);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(107, 30);
            this.BTNEKLE.TabIndex = 5;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(100, 43);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(130, 26);
            this.TXTID.TabIndex = 15;
            // 
            // MSKTEL
            // 
            this.MSKTEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MSKTEL.Location = new System.Drawing.Point(100, 159);
            this.MSKTEL.Mask = "(999) 000-0000";
            this.MSKTEL.Name = "MSKTEL";
            this.MSKTEL.Size = new System.Drawing.Size(130, 26);
            this.MSKTEL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "TEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "MAİL:";
            // 
            // TXTAD
            // 
            this.TXTAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTAD.Location = new System.Drawing.Point(100, 83);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(130, 26);
            this.TXTAD.TabIndex = 1;
            // 
            // TXTSOYAD
            // 
            this.TXTSOYAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTSOYAD.Location = new System.Drawing.Point(100, 121);
            this.TXTSOYAD.Name = "TXTSOYAD";
            this.TXTSOYAD.Size = new System.Drawing.Size(130, 26);
            this.TXTSOYAD.TabIndex = 2;
            // 
            // TXTMAIL
            // 
            this.TXTMAIL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TXTMAIL.Location = new System.Drawing.Point(100, 201);
            this.TXTMAIL.Name = "TXTMAIL";
            this.TXTMAIL.Size = new System.Drawing.Size(130, 26);
            this.TXTMAIL.TabIndex = 4;
            // 
            // BTNSİL
            // 
            this.BTNSİL.Location = new System.Drawing.Point(154, 255);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(107, 30);
            this.BTNSİL.TabIndex = 6;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.UseVisualStyleBackColor = true;
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // BTNGUNCELLE
            // 
            this.BTNGUNCELLE.Location = new System.Drawing.Point(41, 301);
            this.BTNGUNCELLE.Name = "BTNGUNCELLE";
            this.BTNGUNCELLE.Size = new System.Drawing.Size(107, 30);
            this.BTNGUNCELLE.TabIndex = 7;
            this.BTNGUNCELLE.Text = "GÜNCELLE";
            this.BTNGUNCELLE.UseVisualStyleBackColor = true;
            this.BTNGUNCELLE.Click += new System.EventHandler(this.BTNGUNCELLE_Click);
            // 
            // BTNTEMIZLE
            // 
            this.BTNTEMIZLE.Location = new System.Drawing.Point(154, 301);
            this.BTNTEMIZLE.Name = "BTNTEMIZLE";
            this.BTNTEMIZLE.Size = new System.Drawing.Size(107, 30);
            this.BTNTEMIZLE.TabIndex = 8;
            this.BTNTEMIZLE.Text = "TEMİZLE";
            this.BTNTEMIZLE.UseVisualStyleBackColor = true;
            this.BTNTEMIZLE.Click += new System.EventHandler(this.BTNTEMIZLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(893, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MSKTEL;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.Button BTNGUNCELLE;
        private System.Windows.Forms.Button BTNSİL;
        private System.Windows.Forms.TextBox TXTMAIL;
        private System.Windows.Forms.TextBox TXTSOYAD;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.Button BTNTEMIZLE;
    }
}

