namespace loto
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSayi = new System.Windows.Forms.Button();
            this.btDon = new System.Windows.Forms.Button();
            this.btSirala = new System.Windows.Forms.Button();
            this.lbsayilar = new System.Windows.Forms.Label();
            this.lbsirali = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSayi
            // 
            this.btSayi.Location = new System.Drawing.Point(120, 108);
            this.btSayi.Name = "btSayi";
            this.btSayi.Size = new System.Drawing.Size(89, 41);
            this.btSayi.TabIndex = 0;
            this.btSayi.Text = "Sayı Çek";
            this.btSayi.UseVisualStyleBackColor = true;
            this.btSayi.Click += new System.EventHandler(this.btSayi_Click);
            // 
            // btDon
            // 
            this.btDon.Location = new System.Drawing.Point(263, 108);
            this.btDon.Name = "btDon";
            this.btDon.Size = new System.Drawing.Size(89, 41);
            this.btDon.TabIndex = 1;
            this.btDon.Text = "Başa Dön";
            this.btDon.UseVisualStyleBackColor = true;
            this.btDon.Click += new System.EventHandler(this.btDon_Click);
            // 
            // btSirala
            // 
            this.btSirala.Location = new System.Drawing.Point(420, 108);
            this.btSirala.Name = "btSirala";
            this.btSirala.Size = new System.Drawing.Size(89, 41);
            this.btSirala.TabIndex = 2;
            this.btSirala.Text = "Sirala";
            this.btSirala.UseVisualStyleBackColor = true;
            this.btSirala.Click += new System.EventHandler(this.btSirala_Click);
            // 
            // lbsayilar
            // 
            this.lbsayilar.AutoSize = true;
            this.lbsayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbsayilar.Location = new System.Drawing.Point(120, 50);
            this.lbsayilar.Name = "lbsayilar";
            this.lbsayilar.Size = new System.Drawing.Size(185, 39);
            this.lbsayilar.TabIndex = 3;
            this.lbsayilar.Text = "0 0 0 0 0 0 ";
            // 
            // lbsirali
            // 
            this.lbsirali.AutoSize = true;
            this.lbsirali.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbsirali.Location = new System.Drawing.Point(120, 180);
            this.lbsirali.Name = "lbsirali";
            this.lbsirali.Size = new System.Drawing.Size(176, 39);
            this.lbsirali.TabIndex = 4;
            this.lbsirali.Text = "0 0 0 0 0 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 287);
            this.Controls.Add(this.lbsirali);
            this.Controls.Add(this.lbsayilar);
            this.Controls.Add(this.btSirala);
            this.Controls.Add(this.btDon);
            this.Controls.Add(this.btSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSayi;
        private System.Windows.Forms.Button btDon;
        private System.Windows.Forms.Button btSirala;
        private System.Windows.Forms.Label lbsayilar;
        private System.Windows.Forms.Label lbsirali;
    }
}

