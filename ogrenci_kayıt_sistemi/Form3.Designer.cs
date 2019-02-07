namespace ogrenci_kayıt_sistemi
{
    partial class Form3
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
            this.dgv_ara = new System.Windows.Forms.DataGridView();
            this.btn_ara = new System.Windows.Forms.Button();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ara
            // 
            this.dgv_ara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ara.Location = new System.Drawing.Point(12, 12);
            this.dgv_ara.Name = "dgv_ara";
            this.dgv_ara.Size = new System.Drawing.Size(760, 69);
            this.dgv_ara.TabIndex = 0;
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(301, 137);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(100, 21);
            this.btn_ara.TabIndex = 1;
            this.btn_ara.Text = "ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // tb_ara
            // 
            this.tb_ara.Location = new System.Drawing.Point(355, 111);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(100, 20);
            this.tb_ara.TabIndex = 2;
            this.tb_ara.Text = "ogr no gir";
            this.tb_ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(407, 137);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 21);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 170);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.tb_ara);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.dgv_ara);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.Button btn_sil;
    }
}