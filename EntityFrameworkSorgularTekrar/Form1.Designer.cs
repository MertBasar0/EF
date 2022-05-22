namespace EntityFrameworkSorgularTekrar
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
            this.btn_Sorgu1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sorgu2 = new System.Windows.Forms.Button();
            this.btn_sorgu3 = new System.Windows.Forms.Button();
            this.btn_sorgu4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sorgu1
            // 
            this.btn_Sorgu1.Location = new System.Drawing.Point(12, 12);
            this.btn_Sorgu1.Name = "btn_Sorgu1";
            this.btn_Sorgu1.Size = new System.Drawing.Size(145, 38);
            this.btn_Sorgu1.TabIndex = 0;
            this.btn_Sorgu1.Text = "Sorgu1";
            this.btn_Sorgu1.UseVisualStyleBackColor = true;
            this.btn_Sorgu1.Click += new System.EventHandler(this.btn_Sorgu1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 570);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // btn_sorgu2
            // 
            this.btn_sorgu2.Location = new System.Drawing.Point(227, 12);
            this.btn_sorgu2.Name = "btn_sorgu2";
            this.btn_sorgu2.Size = new System.Drawing.Size(130, 38);
            this.btn_sorgu2.TabIndex = 3;
            this.btn_sorgu2.Text = "sorgu2";
            this.btn_sorgu2.UseVisualStyleBackColor = true;
            this.btn_sorgu2.Click += new System.EventHandler(this.btn_sorgu2_Click);
            // 
            // btn_sorgu3
            // 
            this.btn_sorgu3.Location = new System.Drawing.Point(445, 12);
            this.btn_sorgu3.Name = "btn_sorgu3";
            this.btn_sorgu3.Size = new System.Drawing.Size(150, 38);
            this.btn_sorgu3.TabIndex = 4;
            this.btn_sorgu3.Text = "Sorgu3";
            this.btn_sorgu3.UseVisualStyleBackColor = true;
            this.btn_sorgu3.Click += new System.EventHandler(this.btn_sorgu3_Click);
            // 
            // btn_sorgu4
            // 
            this.btn_sorgu4.Location = new System.Drawing.Point(650, 13);
            this.btn_sorgu4.Name = "btn_sorgu4";
            this.btn_sorgu4.Size = new System.Drawing.Size(150, 38);
            this.btn_sorgu4.TabIndex = 4;
            this.btn_sorgu4.Text = "Sorgu4";
            this.btn_sorgu4.UseVisualStyleBackColor = true;
            this.btn_sorgu4.Click += new System.EventHandler(this.btn_sorgu4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 693);
            this.Controls.Add(this.btn_sorgu4);
            this.Controls.Add(this.btn_sorgu3);
            this.Controls.Add(this.btn_sorgu2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sorgu1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sorgu1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sorgu2;
        private System.Windows.Forms.Button btn_sorgu3;
        private System.Windows.Forms.Button btn_sorgu4;
    }
}

