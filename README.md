E-Ticaret Web Sitesi

Bu, ASP.NET MVC, C# ve SQLite kullanarak yapılmış küçük çaplı bir e-ticaret web sitesidir. Ürün ekleme/çıkarmanın yanı sıra, alışveriş sepeti yönetimi gibi özellikler içerir.

Özellikler

Ürün Yönetimi: Ürünleri katalogdan ekleyip çıkarma.
Alışveriş Sepeti: Ürünleri sepete ekleyip çıkarma, sepete göz atma.
SQLite Veritabanı: Ürün bilgileri ve sepet verileri için veritabanı kullanımı.
Kullanılan Teknolojiler

ASP.NET MVC: Web uygulamasının yapısını oluşturmak için kullanıldı.
C#: Uygulama mantığı ve işlevselliği için kullanılan programlama dili.
SQLite: Ürün ve sepet verilerini saklamak için kullanılan veritabanı.
Kurulum

Reposunu bilgisayarınıza klonlayın:
git clone <repository-url>
Projeyi Visual Studio (veya tercih ettiğiniz IDE) ile açın.
NuGet paketlerini geri yükleyin:
dotnet restore
Projeyi derleyin:
dotnet build
Uygulamayı çalıştırın:
dotnet run
Uygulama şu adreste çalışacaktır: http://localhost:5000.
Veritabanı

Bu proje SQLite kullanarak verileri saklar. Veritabanı şeması, uygulama ilk kez çalıştırıldığında otomatik olarak oluşturulacaktır.

Kullanım

Yönetici arayüzü üzerinden ürünleri katalogunuza ekleyin.
Katalogu gezerek ürünleri sepete ekleyin.
Sepetinizi görüntüleyin, ürün miktarlarını değiştirin veya öğeleri çıkarın.
Ödeme işlemine geçiş yapın (uygulamanızda bu özellik varsa).
Katkı Sağlama

Bu repository'yi fork'layarak veya pull request göndererek iyileştirme veya hata düzeltmeleri yapabilirsiniz.

Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.
