namespace Hastane_Proje
{
    partial class frmSekreterGiris
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
            this.linkLabel_uyeOl = new System.Windows.Forms.LinkLabel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.mskdtxtSifre = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel_uyeOl
            // 
            this.linkLabel_uyeOl.AutoSize = true;
            this.linkLabel_uyeOl.Location = new System.Drawing.Point(201, 262);
            this.linkLabel_uyeOl.Name = "linkLabel_uyeOl";
            this.linkLabel_uyeOl.Size = new System.Drawing.Size(43, 16);
            this.linkLabel_uyeOl.TabIndex = 13;
            this.linkLabel_uyeOl.TabStop = true;
            this.linkLabel_uyeOl.Text = "üye ol";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(157, 206);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(149, 30);
            this.btnGirisYap.TabIndex = 12;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // mskdtxtSifre
            // 
            this.mskdtxtSifre.Location = new System.Drawing.Point(157, 147);
            this.mskdtxtSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskdtxtSifre.Name = "mskdtxtSifre";
            this.mskdtxtSifre.Size = new System.Drawing.Size(149, 22);
            this.mskdtxtSifre.TabIndex = 11;
            // 
            // mskdtxtTcNo
            // 
            this.mskdtxtTcNo.Location = new System.Drawing.Point(157, 106);
            this.mskdtxtTcNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskdtxtTcNo.Mask = "00000000000";
            this.mskdtxtTcNo.Name = "mskdtxtTcNo";
            this.mskdtxtTcNo.Size = new System.Drawing.Size(149, 22);
            this.mskdtxtTcNo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TcNo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // frmSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(450, 352);
            this.Controls.Add(this.linkLabel_uyeOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.mskdtxtSifre);
            this.Controls.Add(this.mskdtxtTcNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSekreterGiris";
            this.Text = "frmSekreterGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_uyeOl;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.MaskedTextBox mskdtxtSifre;
        private System.Windows.Forms.MaskedTextBox mskdtxtTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}