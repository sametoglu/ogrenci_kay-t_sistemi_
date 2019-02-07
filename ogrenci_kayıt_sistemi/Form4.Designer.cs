namespace ogrenci_kayıt_sistemi
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.TextBox();
            this.tb_vize = new System.Windows.Forms.TextBox();
            this.btn_notgir = new System.Windows.Forms.Button();
            this.dgv_notgir = new System.Windows.Forms.DataGridView();
            this.tb_tcno = new System.Windows.Forms.TextBox();
            this.btn_goster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notgir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "final";
            // 
            // tb_final
            // 
            this.tb_final.Location = new System.Drawing.Point(65, 98);
            this.tb_final.Name = "tb_final";
            this.tb_final.Size = new System.Drawing.Size(99, 20);
            this.tb_final.TabIndex = 3;
            // 
            // tb_vize
            // 
            this.tb_vize.Location = new System.Drawing.Point(65, 58);
            this.tb_vize.Name = "tb_vize";
            this.tb_vize.Size = new System.Drawing.Size(99, 20);
            this.tb_vize.TabIndex = 4;
            // 
            // btn_notgir
            // 
            this.btn_notgir.Location = new System.Drawing.Point(65, 141);
            this.btn_notgir.Name = "btn_notgir";
            this.btn_notgir.Size = new System.Drawing.Size(99, 23);
            this.btn_notgir.TabIndex = 5;
            this.btn_notgir.Text = "not gir";
            this.btn_notgir.UseVisualStyleBackColor = true;
            this.btn_notgir.Click += new System.EventHandler(this.btn_notgir_Click);
            // 
            // dgv_notgir
            // 
            this.dgv_notgir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notgir.Location = new System.Drawing.Point(235, 14);
            this.dgv_notgir.Name = "dgv_notgir";
            this.dgv_notgir.Size = new System.Drawing.Size(513, 150);
            this.dgv_notgir.TabIndex = 6;
            // 
            // tb_tcno
            // 
            this.tb_tcno.Location = new System.Drawing.Point(65, 14);
            this.tb_tcno.Name = "tb_tcno";
            this.tb_tcno.Size = new System.Drawing.Size(99, 20);
            this.tb_tcno.TabIndex = 7;
            this.tb_tcno.Text = "tcno gir";
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(65, 173);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(99, 23);
            this.btn_goster.TabIndex = 8;
            this.btn_goster.Text = "göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 208);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.tb_tcno);
            this.Controls.Add(this.dgv_notgir);
            this.Controls.Add(this.btn_notgir);
            this.Controls.Add(this.tb_vize);
            this.Controls.Add(this.tb_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notgir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_final;
        private System.Windows.Forms.TextBox tb_vize;
        private System.Windows.Forms.Button btn_notgir;
        private System.Windows.Forms.DataGridView dgv_notgir;
        private System.Windows.Forms.TextBox tb_tcno;
        private System.Windows.Forms.Button btn_goster;
    }
}