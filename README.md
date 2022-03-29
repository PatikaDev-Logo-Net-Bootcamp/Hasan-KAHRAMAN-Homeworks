# HasanKAHRAMAN-Homeworks




1. Hafta Ödevi - Homework1


Verilen Ödev -->
Merhaba Arkadaşlar 1. Hafta Ödeviniz
Bir adet form oluşturulacak. Form içinde ad soyad email ve password için input olacak.(Login ekranı gibi)
Api yazılacak ve HttPost methodunu kullanacak.
EMail validasyonda girilen email uygun olup olmadığı kontrol edilsin.
Password için uzunluk kontrolü 8 karakter olacak en az 1 büyük harf en az 1 karakter en az bir sayı olacak.
Dataannotions da RegEx attribute custom attribute yazabilirsiniz validasyonlar için.
Hata mesajları Türkçe olmalıdır.
Response tipi için class yazılacak.
Prop olarak Success error ve data olacak.
Başarılı postlar success true data giriş işlemi başarılı error null gelecek.
Hatalı postlar succes false data null error hatalı giriş dönecek
Tüm alanlar zorunlu olmalıdır.
Referans : https://stackoverflow.com/questions/16796445/net-regex-specific-to-net-c-sharp-dataannotations


2. Hafta Ödevi - Homework2.Api

Verilen Ödev -->
Middleware yazılacak. İçeriği App version control (bu middleware option parametresi alacak parametre olarakta appsetting.json gelen app-version section değeri alacak)
request login ve register ise bir sonraki pipeline'a geçsin (bu requestler dahil değildir altaki işlemler kontrol edilmeyecek)
request header da app-version key olacak, request header da gönderdiğim app-version değeri appsetting.json tuttuğum app-version değerinden büyükse response 401 status kod olacak
Swagger headerına app-version default key eklenecek. (IOperationFilter interface kullanılarak)
Swagger 4 endpoint oluşturulacak istediğiniz gibi olabilir. Sadece bir tanesi gösterilmeyecek.
Microsoft version classı ile version karşılaştırması yapabilirsiniz.
Middleware ve IOC hakkında 2 dakikalık okunacak, ingilizcesi iyi olanlar ingilizce yazacaklar, yetersiz olanlar ise türkçe makale yayımlayacaklar. Linkedin ve Medium yayınlanacak. Yayınlamadan önce telegram grubunda paylaşın ve birbirinize geri dönüş yapınız.


3. Hafta Ödevi - Homework3

Homework three

MSSQL de LogoDb adında 1 database oluşturulacak. Bu databasede 2 tane tablo oluşturulacak Company ve User. Kolonların sayılarını kendileri belirleyebilirler ama mutlaka Id alanı Primary Key olmalı ve bir User'in sadece 1 Company'si olmalıdır. FK ile tablolalar birbirine bağlanılmasını bekliyorum. Bu tablolara insert işlemi yapan Stored Procedure yazılacak. Bu işlemler Script dosyası olarak iletilecekler

4. Hafta Ödevi - Homework 4

Homework four

İlerlediğimiz projede yazdığımız CompanyService için sadece add ve get işlemi yapmıştık. Delete ve Update methodlarını implement edip apii de bunları kullanmalarını bekliyorum. Proje linkte ulaşabilirsiniz.

https://drive.google.com/file/d/1Pc-3Fa_MjG3SLuO7YhwxJfFTbKO_IMrY/view?usp=drivesdk ,

Ödeve artı 1 puan bonus

Jwt token örneğindeki user ve password bilgilerini db çekecek şekilde UserService yazılması


5. Hafta Ödevi - Homework 5

BackgroundWorker oluşturulacak. https://jsonplaceholder.typicode.com/posts bu linketeki her bir dakikada çalışıp bu bilgileri çekip veri tabanına kayıt eden bir repository oluşturulacak.
https://drive.google.com/file/d/17OUbFAua2kTngQLO7FGY-kxwvXLxnDEZ/view?usp=sharing bunun üstüne oluşturabilirsin. Post diye tablo oluşturulacak migration ile user, id, title, body postun kolonları olacak.
