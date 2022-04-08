namespace EntityFrameworkGiris
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
            this.dgv_sonuclar = new System.Windows.Forms.DataGridView();
            this.btn_musteriGetir = new System.Windows.Forms.Button();
            this.dgv_sonuclar2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sonuclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sonuclar2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sonuclar
            // 
            this.dgv_sonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sonuclar.Location = new System.Drawing.Point(12, 146);
            this.dgv_sonuclar.Name = "dgv_sonuclar";
            this.dgv_sonuclar.Size = new System.Drawing.Size(639, 427);
            this.dgv_sonuclar.TabIndex = 0;
            // 
            // btn_musteriGetir
            // 
            this.btn_musteriGetir.Location = new System.Drawing.Point(12, 12);
            this.btn_musteriGetir.Name = "btn_musteriGetir";
            this.btn_musteriGetir.Size = new System.Drawing.Size(284, 128);
            this.btn_musteriGetir.TabIndex = 1;
            this.btn_musteriGetir.Text = "Müşteri Getir";
            this.btn_musteriGetir.UseVisualStyleBackColor = true;
            this.btn_musteriGetir.Click += new System.EventHandler(this.btn_musteriGetir_Click);
            // 
            // dgv_sonuclar2
            // 
            this.dgv_sonuclar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sonuclar2.Location = new System.Drawing.Point(657, 146);
            this.dgv_sonuclar2.Name = "dgv_sonuclar2";
            this.dgv_sonuclar2.Size = new System.Drawing.Size(639, 427);
            this.dgv_sonuclar2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 583);
            this.Controls.Add(this.btn_musteriGetir);
            this.Controls.Add(this.dgv_sonuclar2);
            this.Controls.Add(this.dgv_sonuclar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sonuclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sonuclar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sonuclar;
        private System.Windows.Forms.Button btn_musteriGetir;
        private System.Windows.Forms.DataGridView dgv_sonuclar2;
    }
}

