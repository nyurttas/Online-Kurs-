namespace _9_EFOnlinecourseDB.Forms
{
    partial class Studentform
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
            txtDTarihi = new MaskedTextBox();
            btnSil = new Button();
            label1 = new Label();
            txtTc = new TextBox();
            btnKaydet = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // txtDTarihi
            // 
            txtDTarihi.Location = new Point(231, 228);
            txtDTarihi.Mask = "00/00/0000";
            txtDTarihi.Name = "txtDTarihi";
            txtDTarihi.Size = new Size(205, 31);
            txtDTarihi.TabIndex = 0;
            txtDTarihi.ValidatingType = typeof(DateTime);
            // 
            // btnSil
            // 
            btnSil.Location = new Point(246, 450);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 21);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci İşlemleri";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(231, 58);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(205, 31);
            txtTc.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(429, 450);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 34);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(231, 108);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(205, 31);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(231, 168);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(205, 31);
            txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 64);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 2;
            label2.Text = "TC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 114);
            label3.Name = "label3";
            label3.Size = new Size(35, 25);
            label3.TabIndex = 2;
            label3.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 174);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 2;
            label4.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 228);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 2;
            label5.Text = "Doğum tarihi";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 25;
            lstListe.Location = new Point(63, 269);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(588, 154);
            lstListe.TabIndex = 4;
            lstListe.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Studentform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(853, 534);
            Controls.Add(lstListe);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtTc);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(btnSil);
            Controls.Add(txtDTarihi);
            Name = "Studentform";
            Text = "Studentform";
            Load += Studentform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtDTarihi;
        private Button btnSil;
        private Label label1;
        private TextBox txtTc;
        private Button btnKaydet;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstListe;
    }
}