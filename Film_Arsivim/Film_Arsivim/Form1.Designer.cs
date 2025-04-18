namespace Film_Arsivim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.TXTKATEGORI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTLINK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNKAYDET = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BTNTAM = new System.Windows.Forms.Button();
            this.BTNH = new System.Windows.Forms.Button();
            this.BTNRENK = new System.Windows.Forms.Button();
            this.BTNCIKIS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.BTNKAYDET);
            this.groupBox2.Controls.Add(this.TXTLINK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXTKATEGORI);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TXTAD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Film ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.Location = new System.Drawing.Point(440, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 341);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(472, 316);
            this.webBrowser1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(235, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 341);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Film Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Ad:";
            // 
            // TXTAD
            // 
            this.TXTAD.Location = new System.Drawing.Point(76, 50);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(141, 26);
            this.TXTAD.TabIndex = 1;
            // 
            // TXTKATEGORI
            // 
            this.TXTKATEGORI.Location = new System.Drawing.Point(76, 82);
            this.TXTKATEGORI.Name = "TXTKATEGORI";
            this.TXTKATEGORI.Size = new System.Drawing.Size(141, 26);
            this.TXTKATEGORI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // TXTLINK
            // 
            this.TXTLINK.Location = new System.Drawing.Point(76, 114);
            this.TXTLINK.Name = "TXTLINK";
            this.TXTLINK.Size = new System.Drawing.Size(141, 26);
            this.TXTLINK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Link:";
            // 
            // BTNKAYDET
            // 
            this.BTNKAYDET.Location = new System.Drawing.Point(76, 146);
            this.BTNKAYDET.Name = "BTNKAYDET";
            this.BTNKAYDET.Size = new System.Drawing.Size(138, 29);
            this.BTNKAYDET.TabIndex = 0;
            this.BTNKAYDET.Text = "Kaydet";
            this.BTNKAYDET.UseVisualStyleBackColor = true;
            this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTNCIKIS);
            this.groupBox5.Controls.Add(this.BTNRENK);
            this.groupBox5.Controls.Add(this.BTNH);
            this.groupBox5.Controls.Add(this.BTNTAM);
            this.groupBox5.Location = new System.Drawing.Point(9, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 154);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlemler";
            // 
            // BTNTAM
            // 
            this.BTNTAM.Location = new System.Drawing.Point(6, 25);
            this.BTNTAM.Name = "BTNTAM";
            this.BTNTAM.Size = new System.Drawing.Size(190, 29);
            this.BTNTAM.TabIndex = 6;
            this.BTNTAM.Text = "Tam Ekran";
            this.BTNTAM.UseVisualStyleBackColor = true;
            // 
            // BTNH
            // 
            this.BTNH.Location = new System.Drawing.Point(6, 59);
            this.BTNH.Name = "BTNH";
            this.BTNH.Size = new System.Drawing.Size(190, 29);
            this.BTNH.TabIndex = 7;
            this.BTNH.Text = "Hakkımızda";
            this.BTNH.UseVisualStyleBackColor = true;
            this.BTNH.Click += new System.EventHandler(this.BTNH_Click);
            // 
            // BTNRENK
            // 
            this.BTNRENK.Location = new System.Drawing.Point(6, 94);
            this.BTNRENK.Name = "BTNRENK";
            this.BTNRENK.Size = new System.Drawing.Size(190, 29);
            this.BTNRENK.TabIndex = 8;
            this.BTNRENK.Text = "Renk Değiştir";
            this.BTNRENK.UseVisualStyleBackColor = true;
            // 
            // BTNCIKIS
            // 
            this.BTNCIKIS.Location = new System.Drawing.Point(6, 125);
            this.BTNCIKIS.Name = "BTNCIKIS";
            this.BTNCIKIS.Size = new System.Drawing.Size(190, 29);
            this.BTNCIKIS.TabIndex = 9;
            this.BTNCIKIS.Text = "Çıkış";
            this.BTNCIKIS.UseVisualStyleBackColor = true;
            this.BTNCIKIS.Click += new System.EventHandler(this.BTNCIKIS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(196, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "SİNEMA KOLTUK YAZILIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(921, 443);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTNKAYDET;
        private System.Windows.Forms.TextBox TXTLINK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTKATEGORI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BTNCIKIS;
        private System.Windows.Forms.Button BTNRENK;
        private System.Windows.Forms.Button BTNH;
        private System.Windows.Forms.Button BTNTAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

