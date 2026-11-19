namespace Nesne_Quiz_Ödevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dgvAraclar = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtFiyat = new TextBox();
            txtYil = new TextBox();
            txtModel = new TextBox();
            txtMarka = new TextBox();
            txtPlaka = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            dgvMusteriListesi = new DataGridView();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            txtEhliyet = new TextBox();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dgvMusteriler = new DataGridView();
            tabPage4 = new TabPage();
            dgvKiralamalar = new DataGridView();
            button8 = new Button();
            button7 = new Button();
            txtGunSayisi = new TextBox();
            txtAracId = new TextBox();
            txtMusteriId = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dvgKiralamalar = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKiralamalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgKiralamalar).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, -8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1747, 633);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvAraclar);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txtFiyat);
            tabPage2.Controls.Add(txtYil);
            tabPage2.Controls.Add(txtModel);
            tabPage2.Controls.Add(txtMarka);
            tabPage2.Controls.Add(txtPlaka);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1136, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Araç Yönetimi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAraclar
            // 
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(307, 0);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.Size = new Size(1426, 591);
            dgvAraclar.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(119, 305);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 248);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 12;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(52, 248);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(157, 206);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 10;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(157, 163);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(125, 27);
            txtYil.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(157, 121);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(157, 86);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 7;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(157, 41);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(125, 27);
            txtPlaka.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 206);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 5;
            label5.Text = "Fiyat";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 170);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 4;
            label4.Text = "Yıl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 128);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 89);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 48);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "Plaka";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-45, -6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1764, 584);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvMusteriListesi);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(txtEhliyet);
            tabPage3.Controls.Add(txtTelefon);
            tabPage3.Controls.Add(txtSoyad);
            tabPage3.Controls.Add(txtAd);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(dgvMusteriler);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1739, 600);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Müşteri Yönetimi";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvMusteriListesi
            // 
            dgvMusteriListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriListesi.Location = new Point(305, 0);
            dgvMusteriListesi.Name = "dgvMusteriListesi";
            dgvMusteriListesi.RowHeadersWidth = 51;
            dgvMusteriListesi.Size = new Size(1418, 586);
            dgvMusteriListesi.TabIndex = 11;
            // 
            // button6
            // 
            button6.Location = new Point(193, 281);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 10;
            button6.Text = "Güncelle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(129, 332);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Sil";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(79, 281);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 1;
            button4.Text = "Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtEhliyet
            // 
            txtEhliyet.Location = new Point(162, 193);
            txtEhliyet.Name = "txtEhliyet";
            txtEhliyet.Size = new Size(125, 27);
            txtEhliyet.TabIndex = 8;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(162, 149);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(162, 104);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(162, 71);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 196);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 4;
            label9.Text = "Ehliyet No";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 152);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 3;
            label8.Text = "Telefon ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 111);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 2;
            label7.Text = "Soyad";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 72);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 1;
            label6.Text = "Ad";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(-15, -9);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(1752, 608);
            dgvMusteriler.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvKiralamalar);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(txtGunSayisi);
            tabPage4.Controls.Add(txtAracId);
            tabPage4.Controls.Add(txtMusteriId);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(dvgKiralamalar);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1739, 600);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kiralama İşlemleri";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvKiralamalar
            // 
            dgvKiralamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiralamalar.Location = new Point(302, 0);
            dgvKiralamalar.Name = "dgvKiralamalar";
            dgvKiralamalar.RowHeadersWidth = 51;
            dgvKiralamalar.Size = new Size(1434, 597);
            dgvKiralamalar.TabIndex = 9;
            // 
            // button8
            // 
            button8.Location = new Point(156, 249);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 8;
            button8.Text = "İade Al(Sil)";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(43, 249);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 7;
            button7.Text = "Kirala";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.Location = new Point(125, 163);
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(125, 27);
            txtGunSayisi.TabIndex = 6;
            // 
            // txtAracId
            // 
            txtAracId.Location = new Point(125, 106);
            txtAracId.Name = "txtAracId";
            txtAracId.Size = new Size(125, 27);
            txtAracId.TabIndex = 5;
            // 
            // txtMusteriId
            // 
            txtMusteriId.Location = new Point(125, 51);
            txtMusteriId.Name = "txtMusteriId";
            txtMusteriId.Size = new Size(125, 27);
            txtMusteriId.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 163);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 3;
            label12.Text = "Kaç Gün?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 106);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 2;
            label11.Text = "Araç ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 51);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 1;
            label10.Text = "Müşteri ID";
            // 
            // dvgKiralamalar
            // 
            dvgKiralamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgKiralamalar.Location = new Point(0, 3);
            dvgKiralamalar.Name = "dvgKiralamalar";
            dvgKiralamalar.RowHeadersWidth = 51;
            dvgKiralamalar.Size = new Size(1802, 580);
            dvgKiralamalar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKiralamalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgKiralamalar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFiyat;
        private TextBox txtYil;
        private TextBox txtModel;
        private TextBox txtMarka;
        private TextBox txtPlaka;
        private Label label5;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvAraclar;
        private TextBox txtEhliyet;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dgvMusteriler;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dgvMusteriListesi;
        private TextBox txtGunSayisi;
        private TextBox txtAracId;
        private TextBox txtMusteriId;
        private Label label12;
        private Label label11;
        private Label label10;
        private DataGridView dvgKiralamalar;
        private DataGridView dgvKiralamalar;
        private Button button8;
        private Button button7;
    }
}
