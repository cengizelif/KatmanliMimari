namespace WindowsFormUI
{
    partial class KategoriForm
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_tanim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_katad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_kategoriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(674, 12);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(91, 23);
            this.btn_Ekle.TabIndex = 9;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_tanim
            // 
            this.txt_tanim.Location = new System.Drawing.Point(324, 14);
            this.txt_tanim.Name = "txt_tanim";
            this.txt_tanim.Size = new System.Drawing.Size(344, 20);
            this.txt_tanim.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategori Tanımı";
            // 
            // txt_katad
            // 
            this.txt_katad.Location = new System.Drawing.Point(86, 14);
            this.txt_katad.Name = "txt_katad";
            this.txt_katad.Size = new System.Drawing.Size(139, 20);
            this.txt_katad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kategori Adı";
            // 
            // dgv_kategoriler
            // 
            this.dgv_kategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kategoriler.Location = new System.Drawing.Point(19, 51);
            this.dgv_kategoriler.Name = "dgv_kategoriler";
            this.dgv_kategoriler.Size = new System.Drawing.Size(746, 302);
            this.dgv_kategoriler.TabIndex = 10;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 367);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_tanim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_katad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_kategoriler);
            this.Name = "KategoriForm";
            this.Text = "KategoriForm";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_tanim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_katad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_kategoriler;
    }
}