namespace Hastane_Proje
{
    partial class frmHastaGirisPaneli
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
            this.label3 = new System.Windows.Forms.Label();
            this.mskdtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtSifre = new System.Windows.Forms.MaskedTextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.linkLabel_uyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TcNo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // mskdtxtTcNo
            // 
            this.mskdtxtTcNo.Location = new System.Drawing.Point(179, 79);
            this.mskdtxtTcNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskdtxtTcNo.Mask = "00000000000";
            this.mskdtxtTcNo.Name = "mskdtxtTcNo";
            this.mskdtxtTcNo.Size = new System.Drawing.Size(149, 30);
            this.mskdtxtTcNo.TabIndex = 3;
            // 
            // mskdtxtSifre
            // 
            this.mskdtxtSifre.Location = new System.Drawing.Point(179, 120);
            this.mskdtxtSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskdtxtSifre.Name = "mskdtxtSifre";
            this.mskdtxtSifre.Size = new System.Drawing.Size(149, 30);
            this.mskdtxtSifre.TabIndex = 4;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(179, 179);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(149, 30);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // linkLabel_uyeOl
            // 
            this.linkLabel_uyeOl.AutoSize = true;
            this.linkLabel_uyeOl.Location = new System.Drawing.Point(223, 235);
            this.linkLabel_uyeOl.Name = "linkLabel_uyeOl";
            this.linkLabel_uyeOl.Size = new System.Drawing.Size(60, 23);
            this.linkLabel_uyeOl.TabIndex = 6;
            this.linkLabel_uyeOl.TabStop = true;
            this.linkLabel_uyeOl.Text = "üye ol";
            this.linkLabel_uyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_uyeOl_LinkClicked);
            // 
            // frmHastaGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 284);
            this.Controls.Add(this.linkLabel_uyeOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.mskdtxtSifre);
            this.Controls.Add(this.mskdtxtTcNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHastaGirisPaneli";
            this.Text = "frmHastaGirisPaneli";
            this.Load += new System.EventHandler(this.frmHastaGirisPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdtxtTcNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel linkLabel_uyeOl;
    }
}