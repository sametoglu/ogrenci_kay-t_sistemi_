namespace ogrenci_kayıt_sistemi
{
    partial class Form2
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
            this.dgv_listele = new System.Windows.Forms.DataGridView();
            this.btn_goster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listele
            // 
            this.dgv_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listele.Location = new System.Drawing.Point(12, 12);
            this.dgv_listele.Name = "dgv_listele";
            this.dgv_listele.RowHeadersWidth = 70;
            this.dgv_listele.Size = new System.Drawing.Size(744, 243);
            this.dgv_listele.TabIndex = 0;
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(285, 261);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(178, 41);
            this.btn_goster.TabIndex = 20;
            this.btn_goster.Text = "goster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 318);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.dgv_listele);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listele;
        private System.Windows.Forms.Button btn_goster;

    }
}