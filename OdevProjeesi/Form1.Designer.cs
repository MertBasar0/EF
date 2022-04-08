namespace OdevProjeesi
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_tckn = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Tckn = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_KisiAra = new System.Windows.Forms.TextBox();
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 42);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(20, 13);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(12, 75);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(37, 13);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(12, 111);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(43, 13);
            this.lbl_tel.TabIndex = 1;
            this.lbl_tel.Text = "Telefon";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 143);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 1;
            this.lbl_mail.Text = "E-mail";
            // 
            // lbl_tckn
            // 
            this.lbl_tckn.AutoSize = true;
            this.lbl_tckn.Location = new System.Drawing.Point(12, 175);
            this.lbl_tckn.Name = "lbl_tckn";
            this.lbl_tckn.Size = new System.Drawing.Size(32, 13);
            this.lbl_tckn.TabIndex = 1;
            this.lbl_tckn.Text = "Tckn";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(118, 39);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 20);
            this.txt_Ad.TabIndex = 2;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(118, 108);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 20);
            this.txt_Tel.TabIndex = 2;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(118, 72);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Tckn
            // 
            this.txt_Tckn.Location = new System.Drawing.Point(118, 172);
            this.txt_Tckn.Name = "txt_Tckn";
            this.txt_Tckn.Size = new System.Drawing.Size(100, 20);
            this.txt_Tckn.TabIndex = 2;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(118, 140);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 20);
            this.txt_Mail.TabIndex = 2;
            // 
            // txt_KisiAra
            // 
            this.txt_KisiAra.Location = new System.Drawing.Point(545, 39);
            this.txt_KisiAra.Name = "txt_KisiAra";
            this.txt_KisiAra.Size = new System.Drawing.Size(204, 20);
            this.txt_KisiAra.TabIndex = 2;
            this.txt_KisiAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KisiAra_KeyUp);
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.Location = new System.Drawing.Point(545, 70);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(204, 225);
            this.lst_liste.TabIndex = 3;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(118, 272);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(275, 272);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(419, 272);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 4;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.lst_liste);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_Tckn);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_KisiAra);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.lbl_tckn);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_tckn;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Tckn;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_KisiAra;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
    }
}

