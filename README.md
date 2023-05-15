# FLIGHT RESERVATION
Bu uygulama, kullanıcıların bir uçak rezervasyonu yapmasına olanak tanır. Kullanıcılar, uçuş tarihleri,lokasyon ve koltuk seçimleri gibi bilgileri girerek bir rezervasyon yaparlar
bu program C# dili kullanılarak oluşturulmuştur çalıştırmak için visual studio kullanılır.


ÖRNEK KULLANIMI AŞAĞIDAKİ GİBİDİR
İSİM GİRİNİZ: CEREN
SOYİSİM GİRİNİZ: CEREN ERGELEN
CİNSİYETİNİZ: KADIN
YAŞINIZ:22
E-POSTA GİRİNİZ: cerenergelen@gmail.com

1: Turkey, Istanbul, Turkish Airlines, 
2: USA,  New York,  Laguardia Airlines, 
3: France,  Paris, AirlineCompany: Air france, 
4: Germany,  Berlin, AirlineCompany: Lufthansa, 
5: Germany,  Berlin,  Schoenefeld, 
6: Italia, Cenova,  Punta Raisi, 
7: Russia, Moskow, Vnukova, 
8: Italia,  Milano,  Punta Raisi, 
9: Turkey,  Ankara,  Esenboğa Airlines 
10: France,  Lyon,  Air France,
lokasyonlardan birini seçiniz: 1

1. 16 mayis 2023 15.00
2. 17 mayis 2023 15.00
3. 17 mayis 2023 19.00
4. 19 mayis 2023 21.00
5. 14 mayıs 2023 12.00
6. 12 mayis 2023 5.00
7. 26 mayis 2023 9.00
8. 28 mayis 2023 15.00
9. 6 mayis 2023 1.00
10. 17 mayis 2023 17.00
lokasyon için saat seçiniz: 2

koltuk seçiminizi yapın: 1
koltuk numarası 1. cam kenarı
koltuk numarası 2. orta kısım
koltuk numarası 3.koridor tarafı

ödeme tutarı :1500 tl

ödeme tipini giriniz 1.kredi kartı/ 2.banka kartı:1

kredi kartıyla ödeme seçimi başarılı

kart numarasını giriniz:1234123412341234(16 karakterden az veya fazla girilmesi durumunda sistem eror verecek ve tekrar girilmesini isteyecek)
geçerli kart numarası:1234123412341234

cvv kodunu giriniz:234 (3 karakterden az veya fazla girilmesi durumunda sistem eror verecek ve tekrar girmesini isteyecek)

kartın son kullanma tarihi:1223(4 karakterden fazla veya az girilmesi durumunda sistem tekrar girilmesini isteyecek)

Siz ceren ergelen(22) başarıyla rezervasyon yaptınız
uçak biletiyle ilgili detaylar cerenergelen@gmail.com adresinize yollanacaktır.
tarih bilgileri:
17/mayis/2023 15.00
konum bilgileri:
Istanbul/Turkey,Turkish Airlines
seçtiğiniz koltuk: Cam kenarı
ödeme tutarı :1500






   
       




Kullanıcı bilgilerinin girilebilmesi için bir sınıf oluşturdum ve bu sınıftaki bilgilere uygulama içindeki diğer sınıfların ulaşabilmesi için User adında bir dahili sınıf oluşturdum.

class User : class Base,class Base,Bu ifade, User sınıfının, Base adlı başka bir sınıftan özellikleri alacağını ve User sınıfının, Base sınıfının tüm genel özelliklerine ve davranışlarına erişebileceğini belirtir

UserBase class,Ayrıca Konum, Uçak, Gün ve Rezervasyon sınıflarını da oluşturdum. Bu sınıfların amacını açıklamak için:
Location sınıfı, şehirler, ülkeler ve havaalanları gibi farklı konumlarla ilgili özellikleri ve davranışları içerir. Bu sınıf, uçuşların başlangıç ve bitiş noktalarını tanımlamak için kullanılır.
Day sınıfı, haftanın günleri ile ilgili özellikleri içerir. Bu sınıf, hangi günlerde uçuşların planlanacağını belirlemek için kullanılır
Reservation sınıfı, kullanıcılar tarafından yapılan rezervasyonlarla ilgili özellikleri  içerir. Bu sınıf, hangi kullanıcının hangi uçuşu hangi tarihte, hangi koltukta ve hangi fiyata rezerve ettiği gibi bilgiler içerir.


Program sınıfının içinde paylaşılan verileri tutmak ve diğer sınıflar tarafından da değiştirilebilmesi için 5 tane public static değişken tanımladım.
public static Date lastdate;: lastdate adında bir tarih değişkeni tanımlar. Public static anahtar kelimesi, bu değişkene sınıf dışından doğrudan erişilebileceğini belirtir.


public static Location lastlocation; lastlocation adında bir konum değişkeni tanımlar. Bu değişken de public static olarak tanımlanır.

public static string koltuktipi;: koltuktipi adında bir dize değişkeni tanımlar. Bu değişken de public static olarak tanımlanır.

public static User lastUser;: lastUser adında bir kullanıcı değişkeni tanımlar. Bu değişken de public static olarak tanımlanır.

İlk olarak, kullanıcı bilgilerini saklamak için en fazla 10 adet User objesi tutabilen bir dizi oluşturdum. CreateUser() yöntemini çağırdım ve yeni bir User objesi oluşturdum ve kullanıcı dizisinde sakladım. Daha sonra, kullanıcının konumunu seçmesi için SelectLocation() yöntemini kullandım. Sonrasında, tarih seçimi için SelectDate() yöntemini ekledim. Koltuk seçimi için KoltukSecimiYap() yöntemini kullandım ve ödeme için OdemeYap() yöntemini çağırdım. Ödeme işleminden sonra, kullanıcıya rezervasyon ayrıntılarını göstermek için DetayBilgi yöntemini çağırdım


kullanıcının isim, soyisim, cinsiyet, yaş ve e-posta gibi kişisel bilgilerini almak için kullanılan CreateUser() adlı bir metod yazdım. Bu metot, Console sınıfı kullanılarak kullanıcıdan bu bilgileri girmesini ister. ve bu bilgileri ilgili değişkenlere atar. Yaş bilgisini integer olarak aldım,diğer bilgiler string olarak aldım. Metod aldığı bilgilerle yeni bir user oluşmasını sağlayacak ve bu nesneyi kullanıcı dizisine kaydeder. Console.ForegroundColor özelliği kullanılarak, Console'a yazdırılan metnin rengini koyu yeşil olarak ayarladım


kullanıcının seçebileceği konumlar listeledim. Her konum için bir numara atadım ve kullanıcı, seçmek istediği konumun numarasını girerek seçim yapabilir. Kullanıcının seçimine göre, bir Location nesnesi oluşturulur ve bu nesne lastlocation değişkenine atanır. Ayrıca, Location sınıfındaki özellikler, kullanıcının seçimine göre ayarlanır.


Yazım kolaylığı için Switch-case yapısı kullanarak, seçilen numaraya göre hangi konumun seçildiği belirlenir ve buna göre ilgili Location nesnesi oluşturulur. Bu nesne, kullanıcıya seçilen konum hakkında bilgi vermek için kullanılır.


Son olarak, lastlocation değişkeni, seçilen konum bilgilerini içeren bir Location nesnesiyle güncellenir. Bu değişken, programın farklı kısımlarında kullanılmak üzere tutulur.

Console.ForegroundColor özelliği kullanarak konsolda yazdırılacak metnin rengini koyu mavi olarak ayarladım.


İlk olarak, SelectDate() adlı bir static void metodu oluşturdum. Bu metot, kullanıcının bir tarih seçmesini sağlamak için ekrana bir dizi tarih seçeneği yazdırır ve kullanıcının seçimini okur.Daha sonra, kullanıcının seçtiği seçeneğe bağlı olarak, bir Date nesnesi oluşturur. Bu nesne, seçilen tarihin ayrıntılarını içerir
 farklı seçenekler için ayrı ayrı işlemler yapılmasını sağlamak için switch seçim işlemini kullandım.
 
 
Kullanıcının seçtiği seçenek, case ifadesi ile belirttim ve ilgili işlemler bu ifadenin altına sıraladım. Eğer kullanıcının seçimi geçersiz ise, default ifadesi altında bir hata mesajı yazdırılacak.


 lastdate değişkeni oluşturdum, SelectDate() fonksiyonunda seçilen tarihi saklamak için kullandığım bir değişkendir. lastdate değişkenine seçilen tarihin özellikleri atayarak, bu tarihin diğer yerlerde kullanılabilmesini sağlar . kullanıcının son seçtiği tarihin ayrıntılarını tutmak için kullandım.
 
 
console.WriteLine ile koltuk seçeneklerini gösterdim.kullanıcının koltuk seçimi yapması bekleniyor ve bu seçim, konsol ekranında yazdırılan koltuk numaralarının yanındaki rakamlar aracılığıyla yapılması gerekir. Kullanıcının seçtiği koltuk numarası, konsolda metin olarak girildiği için int.Parse kullanarak bu metni tamsayıya dönüştürdüm. Bu işlem, kullanıcının seçtiği koltuk numarasını bir değişkene atanmasını sağlıyor.


Kullanıcının seçimine göre, switch ifadesi seçilen koltuk tipini belirler. Seçilen koltuk tipine bağlı olarak, koltuktipi değişkeni belirtilir ve Console.WriteLine ifadesiyle kullanıcıya seçimini teyit eden bir mesaj gösterilir. Ayrıca, tutar değişkenine de uygun fiyat bilgisi atanır.


En son olarak, seçilen koltuk tipi sonkoltuk değişkeninde saklanır.


odemeTipi" değişkeni, kullanıcının ödeme yöntemini seçmesi için kullanılır. Kullanıcı 1 veya 2 değerlerini girerek kredi kartı veya banka kartı seçeneklerinden birini seçebilir. "switch" ifadesi kullanılarak, kullanıcının seçimine göre farklı işlemler yapar.bool temp=true ifadesi, temp adında bir değişken tanımlar ve bu değişkenin başlangıç değerini true olarak atar.
Bu değişkenin amacı, bir döngü içerisinde kullanıcıdan girdi alırken veya bir işlem yaparken, gerekli koşullar sağlanana kadar döngüde kalınmasını sağlamaktır. Yani, temp değişkeni, döngüye girerken true olarak atanır ve döngü içerisindeki koşullar sağlanana kadar true değeri korunur. Koşullar sağlandığında temp değişkeni false olarak değiştirilir ve döngü sonlandırılır. Bu şekilde, kullanıcının gerektiği kadar girdi yapması veya işlem yapması sağlanır.


"kartNo" değişkeni, kullanıcının kart numarasını tutar. "size" değişkeni, kullanıcının girdiği kart numarasının uzunluğunu kontrol eder. Kart numarası 16 karakter olmalıdır. "acceptedKartNo" değişkeni, geçerli bir kart numarası girildiğinde, doğru değeri tutar ve ekrana yazdırır.


"cvv" değişkeni, kullanıcının kartın arkasındaki 3 haneli cvv kodunu girmesini sağlar. "size2" değişkeni, kullanıcının girdiği cvv kodunun uzunluğunu kontrol eder. Cvv kodu 3 karakter olmalıdır. "acceptedCvv" değişkeni, geçerli bir cvv kodu girildiğinde, doğru değeri tutar ve ekrana yazdırır.


"sonTarihi" değişkeni, kullanıcının kartın son kullanma tarihini girmesini sağlar. "size3" değişkeni, kullanıcının girdiği son kullanma tarihinin uzunluğunu kontrol eder. Son kullanma tarihi 4 karakter olmalıdır. "acceptedsonkullanmaTarihi" değişkeni, geçerli bir son kullanma tarihi girildiğinde, doğru değeri tutar ve ekrana yazdırır.


Ödeme işlemi, kullanıcının doğru kart bilgilerini girdiğinden emin olduktan sonra gerçekleştirilir. "Ödeme başarıyla gerçekleştirildi." mesajı ekrana yazdırılır.
static void DetayBilgi():fonksiyon, son kullanıcının yaptığı rezervasyonun detaylarını ekrana yazdırmak için kullanılır.


lastUser değişkeninde tutulan son kullanıcının adı, soyadı ve yaş bilgileri Console.WriteLine fonksiyonu ile ekrana yazdırdım. Daha sonra, son kullanıcının e-posta adresine bilet detaylarının gönderileceği bilgisini yazdırdım.


lastdate değişkeninde tutulan tarih bilgileri ve lastlocation değişkeninde tutulan konum bilgileri ayrı ayrı ekrana yazdırılır. Son olarak, seçilen koltuk tipi ve ödeme tutarı bilgileri de yazdırılır.


Console.ForegroundColor özelliği kullanılarak yazı rengi kırmızı olarak ayarladım


 kullanıcının rezervasyon bilgilerini detaylı bir şekilde görüntülemesine yardımcı olmak için tasarladım. Bu bilgilerin doğru olması, kullanıcının seyahat planlamasını doğru yapmasını sağlar.











