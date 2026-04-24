<img width="803" height="541" alt="image" src="https://github.com/user-attachments/assets/3caca855-1995-49d6-affa-415e2cd64ddf" />
💰 Harcama Takip Sistemi (N-Tier Architecture)
Bu proje, kişisel harcamaların yönetilmesi amacıyla Katmanlı Mimari (N-Tier Architecture) yapısı kullanılarak geliştirilmiş bir .NET Windows Forms uygulamasıdır. Projede veritabanı işlemleri için Entity Framework Core kullanılmıştır.

🚀 Özellikler
-Harcama Ekleme: Açıklama, tutar ve kategori bilgileriyle yeni harcamalar kaydedilir.

-Harcama Listeleme: Kayıtlı tüm harcamalar DataGridView üzerinde anlık olarak görüntülenir.

-Harcama Silme: Seçilen harcama, kullanıcı onayı alındıktan sonra veritabanından güvenli bir şekilde silinir.

-İş Kuralları (Validation): Harcama tutarının 0'dan büyük olması gibi temel iş mantığı kontrolleri Business katmanında yönetilir.

🏗️ Kullanılan Teknolojiler
-Dil: C#

-Platform: .NET Desktop (Windows Forms)

-ORM: Entity Framework Core

-Veritabanı: MS SQL Server

-Mimari: N-Tier Architecture (Entities, DataAccess, Business, UI)

📁 Proje Katmanları
Proje 4 ana katmandan oluşmaktadır:

1-Entities: Veritabanı tablolarına karşılık gelen nesne modellerini barındırır.

2-DataAccess: Veritabanı bağlantısı (DbContext) ve CRUD (Ekleme, Silme, Listeleme) operasyonlarını yönetir.

3-Business: Uygulamanın iş mantığını ve kurallarını (Validation) kontrol eder.

4-UI (Presentation): Kullanıcının etkileşime girdiği görsel arayüzdür.

🛠️ Kurulum ve Çalıştırma
1-Projeyi klonlayın: git clone https://github.com/kullaniciadi/HarcamaTakip.git

2-HarcamaTakip.DataAccess katmanındaki ExpenseContext.cs dosyasını açın.

3-Connection String bölümündeki Server bilgisini kendi yerel SQL Server adresinizle güncelleyin:

C#
optionsBuilder.UseSqlServer(@"Server=YOUR_SERVER_NAME;Database=ExpenseDb;Trusted_Connection=True;");

4-Package Manager Console üzerinden veritabanını oluşturun:

PowerShell
Update-Database
Projeyi çalıştırın (F5).

💡 Öğrendiklerim
-Bu projeyi geliştirirken şunları deneyimledim:

-Verilerin katmanlar arasında nasıl güvenli bir şekilde taşındığını kavradım.

-Dependency Injection mantığını kullanarak sınıflar arası bağımlılığı minimize ettim.

Code First yaklaşımıyla C# sınıflarından veritabanı tabloları oluşturdum.

Kullanıcı hatalarını ve veritabanı istisnalarını try-catch bloklarıyla yönetmeyi öğrendim.
