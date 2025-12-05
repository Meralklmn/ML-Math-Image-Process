



📸 ML Matematik Görüntü İşlemi
Bu proje, bir görüntüdeki (resim) kalıcı ifadeleri inceleme (OCR) ve tanımlanan bu ifadeleri uzaktan olarak çözerek sonucunu görüntülemek için tasarlanmış bir Windows Forms uygulamasıdır.

🌟 Özellikler
Görüntü İşleme (OCR): Tesseract motorunu kullanarak resimlerden karakterleri ve geniş sembolleri tanır.

Matematiksel Ayrıştırma: Tanınan ham metin, NCalc kütüphanesi aracılığıyla geçerli kapsamlı ifadelere ulaşılabilir.

Anlık Hesaplama: Basit ve karmaşık aritmetik işlemler anında çözerek sonucunu kullanıcıya sunar.

C# Windows Forms Arayüzü: Kullanımı kolay görsel ayarları (UI).

💻 Teknolojiler
Dil: C#

Çerçeve: .NET (Windows Forms)

Görüntü İşleme / OCR: TesseractSharp (Tesseract motorunun C# Kurulumu)

Matematiksel Çözümleme: NCalc (Güçlü bir kapsamlı ifade ayrıştırıcısı)

⚙️ Kurulum ve Başlatma
Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin.

1. Ön Gereksinimler
Visual Studio 2022 (ve ilgili .NET SDK)

Git

2. Depoyu Klonlama
Proje bileşenlerinin indirilmesi:

Bash

git clone [DEPO_URL'NİZİ BURAYA YAZIN]
cd ML Math Image Process
3. Tesseract Dil Dosyaları (ÖNEMLİ!)
Tesseract motorunun düzgün çalışması için gerekli dil özelliklerini doğru yerleştirmeniz gerekir:

GitHub'da bulunan Tesseract tessdatadeposundan eng.traineddataindirilebilir.

İndirdiğiniz dosyayı kopyalayın, projenizi derleyin, sonra oluşan şu klasörün yolunu bir tessdataklasöre kopyalayın:

[Proje Kök Dizini]\bin\Debug\[NET VERSİYONU]\tessdata
(Örneğin: bin\Debug\net8.0-windows\tessdata)

4. Projeyi Derleme
Visual Studio'yu açın, projeyi yükleyin ve Build -> Build Solution(Derle -> Çözümü Derle) seçeneğiyle projeyi derleyin.

🚀 Kullanım

Uygulamayı ortalama.

"Görsel Seç ve Oku" düğmesine tıklayın.

Üzerinde düzenli olarak ifade eden bir görsel seçin (örneğin, 10 * (5 - 2)).

Uygulama, görseldeki ifadeyi görerek OCR Sonucu alanında metin olarak yazar ve hemen altında Hesaplama Sonucu alanında çözülmüş sayıyı gösterir.
  
