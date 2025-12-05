using NCalc;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tesseract;

// NOT: Buradaki Namespace'i (Ad Alanýný) Visual Studio projenizin adýyla eþleþtirin.
namespace MatematikselIfadeCozucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =========================================================================
        // GÖRSEL SEÇME VE ÝÞLEM AKIÞI METODU
        // =========================================================================
        private void btnGorselSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Görüntü Dosyalarý|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Görseli Yükle ve Göster
                    string imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);
                    pictureBoxGorsel.Image = image;

                    // 2. OCR Ýþlemini Baþlat
                    string rawText = PerformOcr(imagePath);
                    txtSonucOCR.Text = rawText;

                    // 3. Matematiksel Ýfadeyi Çöz
                    CalculateExpression(rawText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSonucOCR.Text = "Hata: Görüntü okunamadý.";
                    txtSonucHesaplama.Text = "Hata.";
                }
            }
        }

        // =========================================================================
        // OPTÝK KARAKTER TANIMA (OCR) METODU
        // =========================================================================
        private string PerformOcr(string imagePath)
        {
            // Tesseract dil dosyalarýnýn bulunduðu yol: bin\Debug\tessdata
            const string TESSDATA_PATH = "./tessdata";

            try
            {
                // Tesseract motorunu 'eng' (Ýngilizce) dil paketiyle baþlat
                using (var engine = new TesseractEngine(TESSDATA_PATH, "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            string text = page.GetText().Trim();
                            return CleanExpression(text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata ayýklama için konsola yazdýr
                Console.WriteLine("Tesseract Hata: " + ex.Message);
                return $"OCR HATA: Tesseract motoru baþlatýlamadý veya dil dosyasý ({TESSDATA_PATH}) bulunamadý. Hata: {ex.Message}";
            }
        }

        // =========================================================================
        // ÝFADE TEMÝZLEME VE ÖN ÝÞLEME METODU
        // =========================================================================
        private string CleanExpression(string input)
        {
            // Ýfadeyi NCalc'in anlayabileceði formata çevirir.
            string cleaned = input
                .Replace(" ", "")    // Boþluklarý kaldýr
                .Replace("=", "")    // Eþittir iþaretini kaldýr (Sadece hesaplama yapýldýðý varsayýlýr)
                .Replace("\n", "")   // Yeni satýrlarý kaldýr
                .Replace(",", ".")   // Ondalýk ayýrýcýyý virgül yerine nokta yap
                .Replace("x", "*")   // "x" harfini çarpma iþareti (*) ile deðiþtir
                .Replace("X", "*")
                .Replace(":", "/")   // Bazý yazýlýmlar bölmeyi iki nokta üst üste (:) ile gösterebilir
                ;

            return cleaned;
        }

        // =========================================================================
        // MATEMATÝKSEL ÝFADE ÇÖZÜMLEME METODU
        // =========================================================================
        private void CalculateExpression(string rawExpression)
        {
            if (string.IsNullOrWhiteSpace(rawExpression) || rawExpression.Contains("HATA"))
            {
                txtSonucHesaplama.Text = "Hesaplanamadý: Geçersiz veya Hatalý ifade.";
                return;
            }

            try
            {
                // NCalc kütüphanesi ile ifadeyi oluþtur ve hesapla
                Expression expression = new Expression(rawExpression);

                // NOT: Eðer ifadede bilinmeyen deðiþken (x gibi) varsa,
                // expression.Parameters["x"] = 5; þeklinde bir deðer atamanýz gerekir.

                var result = expression.Evaluate();

                // Sonucu metin kutusuna yaz
                txtSonucHesaplama.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // Ayrýþtýrma (parsing) veya hesaplama hatasý durumunda
                txtSonucHesaplama.Text = $"Hesaplama Hatasý: {ex.Message}";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}