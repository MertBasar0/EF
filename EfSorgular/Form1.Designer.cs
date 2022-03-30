namespace EfSorgular
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
            this.btn_sorguBir = new System.Windows.Forms.Button();
            this.dgvSorgular = new System.Windows.Forms.DataGridView();
            this.btn_sorgu2 = new System.Windows.Forms.Button();
            this.btn_Sorgu4 = new System.Windows.Forms.Button();
            this.btn_Sorgu5 = new System.Windows.Forms.Button();
            this.btn_sorgu6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorgular)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sorguBir
            // 
            this.btn_sorguBir.Location = new System.Drawing.Point(12, 12);
            this.btn_sorguBir.Name = "btn_sorguBir";
            this.btn_sorguBir.Size = new System.Drawing.Size(114, 49);
            this.btn_sorguBir.TabIndex = 0;
            this.btn_sorguBir.Text = "Sorgu1";
            this.btn_sorguBir.UseVisualStyleBackColor = true;
            this.btn_sorguBir.Click += new System.EventHandler(this.btn_sorguBir_Click);
            // 
            // dgvSorgular
            // 
            this.dgvSorgular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorgular.Location = new System.Drawing.Point(9, 118);
            this.dgvSorgular.Name = "dgvSorgular";
            this.dgvSorgular.Size = new System.Drawing.Size(782, 323);
            this.dgvSorgular.TabIndex = 1;
            // 
            // btn_sorgu2
            // 
            this.btn_sorgu2.Location = new System.Drawing.Point(175, 12);
            this.btn_sorgu2.Name = "btn_sorgu2";
            this.btn_sorgu2.Size = new System.Drawing.Size(114, 49);
            this.btn_sorgu2.TabIndex = 0;
            this.btn_sorgu2.Text = "Sorgu2";
            this.btn_sorgu2.UseVisualStyleBackColor = true;
            this.btn_sorgu2.Click += new System.EventHandler(this.btn_sorgu2_Click);
            // 
            // btn_Sorgu4
            // 
            this.btn_Sorgu4.Location = new System.Drawing.Point(441, 12);
            this.btn_Sorgu4.Name = "btn_Sorgu4";
            this.btn_Sorgu4.Size = new System.Drawing.Size(114, 49);
            this.btn_Sorgu4.TabIndex = 0;
            this.btn_Sorgu4.Text = "Sorgu4";
            this.btn_Sorgu4.UseVisualStyleBackColor = true;
            this.btn_Sorgu4.Click += new System.EventHandler(this.btn_Sorgu4_Click);
            // 
            // btn_Sorgu5
            // 
            this.btn_Sorgu5.Location = new System.Drawing.Point(561, 12);
            this.btn_Sorgu5.Name = "btn_Sorgu5";
            this.btn_Sorgu5.Size = new System.Drawing.Size(114, 49);
            this.btn_Sorgu5.TabIndex = 0;
            this.btn_Sorgu5.Text = "Sorgu5";
            this.btn_Sorgu5.UseVisualStyleBackColor = true;
            this.btn_Sorgu5.Click += new System.EventHandler(this.btn_Sorgu5_Click);
            // 
            // btn_sorgu6
            // 
            this.btn_sorgu6.Location = new System.Drawing.Point(677, 12);
            this.btn_sorgu6.Name = "btn_sorgu6";
            this.btn_sorgu6.Size = new System.Drawing.Size(114, 49);
            this.btn_sorgu6.TabIndex = 0;
            this.btn_sorgu6.Text = "Sorgu6";
            this.btn_sorgu6.UseVisualStyleBackColor = true;
            this.btn_sorgu6.Click += new System.EventHandler(this.btn_sorgu6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSorgular);
            this.Controls.Add(this.btn_sorgu6);
            this.Controls.Add(this.btn_Sorgu5);
            this.Controls.Add(this.btn_Sorgu4);
            this.Controls.Add(this.btn_sorgu2);
            this.Controls.Add(this.btn_sorguBir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorgular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sorguBir;
        private System.Windows.Forms.DataGridView dgvSorgular;
        private System.Windows.Forms.Button btn_sorgu2;
        private System.Windows.Forms.Button btn_Sorgu4;
        private System.Windows.Forms.Button btn_Sorgu5;
        private System.Windows.Forms.Button btn_sorgu6;
    }
}

