namespace KisiselRehber_Tekrar
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
            this.grp_kisiEkle = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_telNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kisiAra = new System.Windows.Forms.TextBox();
            this.grp_kisiEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_kisiEkle
            // 
            this.grp_kisiEkle.Controls.Add(this.txt_telNo);
            this.grp_kisiEkle.Controls.Add(this.txt_soyad);
            this.grp_kisiEkle.Controls.Add(this.txt_kisiAra);
            this.grp_kisiEkle.Controls.Add(this.txt_ad);
            this.grp_kisiEkle.Controls.Add(this.label3);
            this.grp_kisiEkle.Controls.Add(this.label2);
            this.grp_kisiEkle.Controls.Add(this.label4);
            this.grp_kisiEkle.Controls.Add(this.label1);
            this.grp_kisiEkle.Controls.Add(this.btn_guncelle);
            this.grp_kisiEkle.Controls.Add(this.btn_sil);
            this.grp_kisiEkle.Controls.Add(this.btn_ekle);
            this.grp_kisiEkle.Location = new System.Drawing.Point(12, 12);
            this.grp_kisiEkle.Name = "grp_kisiEkle";
            this.grp_kisiEkle.Size = new System.Drawing.Size(776, 210);
            this.grp_kisiEkle.TabIndex = 0;
            this.grp_kisiEkle.TabStop = false;
            this.grp_kisiEkle.Text = "Kisi Ekle";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 228);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 210);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(234, 152);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(91, 32);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(428, 152);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(91, 32);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(622, 152);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(91, 32);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tel No";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(100, 30);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 23);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(100, 68);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 23);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_telNo
            // 
            this.txt_telNo.Location = new System.Drawing.Point(100, 110);
            this.txt_telNo.Mask = "(999) 000-0000";
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Size = new System.Drawing.Size(100, 23);
            this.txt_telNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kişi Ara";
            // 
            // txt_kisiAra
            // 
            this.txt_kisiAra.Location = new System.Drawing.Point(492, 35);
            this.txt_kisiAra.Name = "txt_kisiAra";
            this.txt_kisiAra.Size = new System.Drawing.Size(155, 23);
            this.txt_kisiAra.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grp_kisiEkle);
            this.Name = "Form1";
            this.Text = "Rehber";
            this.grp_kisiEkle.ResumeLayout(false);
            this.grp_kisiEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_kisiEkle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox txt_telNo;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_kisiAra;
        private System.Windows.Forms.Label label4;
    }
}
