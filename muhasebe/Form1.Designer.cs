namespace muhasebe_uygulaması._1
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(737, 509);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlusturListele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSonPersonel;
        private System.Windows.Forms.Button btn400Arttır;
        private System.Windows.Forms.Button btnToplamMaas;
        private System.Windows.Forms.Button bnt4Bin8Bin;
        private System.Windows.Forms.Button btn4BindenAz;
        private System.Windows.Forms.Button btnYuksekMaasPers;
        private System.Windows.Forms.Button btnDusukMaas;
        private System.Windows.Forms.Button btnToplamPersonel;
        private System.Windows.Forms.Button btnListeTemizle;
        private System.Windows.Forms.ListBox lbgoster;
        private System.Windows.Forms.TextBox tbPersonelAra;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
    }
}

