namespace MatematikselIfadeCozucu 
{
    partial class Form1
    {
        /// <summary>
        /// Tasarımcı tarafından kullanılan gerekli değişken.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizler.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynaklar serbest bırakılmalıysa true; aksi halde false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Tasarımcısı tarafından üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun içeriğini
        /// kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            btnGorselSec = new Button();
            pictureBoxGorsel = new PictureBox();
            label1 = new Label();
            txtSonucOCR = new TextBox();
            label2 = new Label();
            txtSonucHesaplama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGorsel).BeginInit();
            SuspendLayout();
            // 
            // btnGorselSec
            // 
            btnGorselSec.Location = new Point(12, 12);
            btnGorselSec.Name = "btnGorselSec";
            btnGorselSec.Size = new Size(200, 30);
            btnGorselSec.TabIndex = 0;
            btnGorselSec.Text = "Görsel Seç ve Oku";
            btnGorselSec.UseVisualStyleBackColor = true;
            btnGorselSec.Click += btnGorselSec_Click;
            // 
            // pictureBoxGorsel
            // 
            pictureBoxGorsel.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxGorsel.Location = new Point(12, 48);
            pictureBoxGorsel.Name = "pictureBoxGorsel";
            pictureBoxGorsel.Size = new Size(400, 300);
            pictureBoxGorsel.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGorsel.TabIndex = 1;
            pictureBoxGorsel.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 2;
            label1.Text = "OCR Sonucu (Ham İfade):";
            // 
            // txtSonucOCR
            // 
            txtSonucOCR.Location = new Point(433, 34);
            txtSonucOCR.Multiline = true;
            txtSonucOCR.Name = "txtSonucOCR";
            txtSonucOCR.ReadOnly = true;
            txtSonucOCR.Size = new Size(350, 149);
            txtSonucOCR.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 186);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 4;
            label2.Text = "Hesaplama Sonucu:";
            label2.Click += label2_Click;
            // 
            // txtSonucHesaplama
            // 
            txtSonucHesaplama.Location = new Point(438, 221);
            txtSonucHesaplama.Name = "txtSonucHesaplama";
            txtSonucHesaplama.ReadOnly = true;
            txtSonucHesaplama.Size = new Size(350, 27);
            txtSonucHesaplama.TabIndex = 5;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 360);
            Controls.Add(txtSonucHesaplama);
            Controls.Add(label2);
            Controls.Add(txtSonucOCR);
            Controls.Add(label1);
            Controls.Add(pictureBoxGorsel);
            Controls.Add(btnGorselSec);
            Name = "Form1";
            Text = "Matematiksel İfade Çözücü";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGorsel).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Tanımlanan Bileşenler:
        private System.Windows.Forms.Button btnGorselSec;
        private System.Windows.Forms.PictureBox pictureBoxGorsel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonucOCR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSonucHesaplama;
    }

}