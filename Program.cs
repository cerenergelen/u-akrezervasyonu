using System.Data;

class User : UserBase
{
}

class Location : LocationBase
{
}

public class Date : DateBase
{
}
class Plane : PlaneBase
{
}

class Reservation : ReservationBase
{
}
class Program
{
    public static Date lastdate;
    public static Location lastlocation;
    public static string koltuktipi;
    public static User lastUser;
    public static double tutar;
    static void Main(string[] args)
    {
        User[] users = new User[10]; // Initialize an array to hold up to 10 users

        Console.WriteLine("Kullanıcı bilgilerinizi giriniz:");

        Console.ResetColor();
        Console.WriteLine();

        CreateUser();
        
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine();
        
        SelectLocation();

        Console.Clear();
        Console.ResetColor();
        Console.WriteLine();

        SelectDate();

       
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine();

        KoltukSecimiYap();

        Console.Clear();
        Console.ResetColor();
        Console.WriteLine();

        OdemeYap();

        Console.Clear();
        Console.ResetColor();
        Console.WriteLine();

        DetayBilgi();

        Plane myPlane = new Plane();
        myPlane.TakeCareDate = new DateTime(2023, 5, 10);
        DateTime takeCareDate = myPlane.TakeCareDate;
        DateTime myDateTime = new DateTime(2023, 5, 5, 15, 30, 0);
    }

    static void CreateUser()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen; // Set the text color to green
        

        Console.Write("İsim giriniz: ");
        string name = Console.ReadLine();

        Console.Write("Soyisim giriniz: ");
        string surname = Console.ReadLine();

        Console.Write("Cinsiyetiniz: ");
        string gender = Console.ReadLine();

        Console.Write("Yaşınızı giriniz: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("E-posta giriniz: ");
        string email = Console.ReadLine();

        lastUser = new User
        {
            Name = name,
            Surname = surname,
            Cinsiyet = gender,
            Age = age,
            Email = email

        };

    }

    static void SelectLocation()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue; // Set the text color to green

        Console.WriteLine("Possible locations:");
        Console.WriteLine("1. Turkey - Istanbul - Turkish Airlines - Working");
        Console.WriteLine("2. USA - New York - LaGuardia Airlines - Working");
        Console.WriteLine("3. France - Paris - Air France - Not working");
        Console.WriteLine("4. Germany - Berlin - Lufthansa - Working");
        Console.WriteLine("5. Germany - Berlin - Schoenefeld  - Working");
        Console.WriteLine("6. Italia - Cenova - Punta Raisi  - Working");
        Console.WriteLine("7. Russia - Moskow - Vnukova  - Working");
        Console.WriteLine("8. Italia - Milano - Punta Raisi  - Working");
        Console.WriteLine("9. Turkey - Ankara - Esenboğa Airlines - Working");
        Console.WriteLine("10. France - Lyon - Air France - working");

        Console.Write("Select a location by entering its number: ");
        int selection = int.Parse(Console.ReadLine());

        Location location = null;
        Date date = null;
        switch (selection)
        {
            
            case 1:

                
                location = new Location
                {
                    Country = "Turkey",
                    City = "Istanbul",
                    AirlineCompany = "Turkish Airlines",
                    IsWorking = true,
                };
                break;
            case 2:
                location = new Location { Country = "USA", City = "New York", AirlineCompany = "Laguardia Airlines", IsWorking = false };
                break;
            case 3:
                location = new Location { Country = "France", City = "Paris", AirlineCompany = "Air france", IsWorking = true };
                break;
            case 4:
                location = new Location { Country = "Germany", City = "Berlin", AirlineCompany = "Lufthansa", IsWorking = true };
                break;
            case 5:
                location = new Location { Country = "Germany", City = "Berlin", AirlineCompany = "Schoenefeld", IsWorking = false };
                break;
            case 6:
                location = new Location { Country = "Italia", City = "Cenova", AirlineCompany = "Punta Raisi", IsWorking = true };
                break;
            case 7:
                location = new Location { Country = "Russia", City = "Moskow", AirlineCompany = "Vnukova", IsWorking = true };
                break;
            case 8:
                location = new Location { Country = "Italia", City = "Milano", AirlineCompany = "Punta Raisi", IsWorking = true };
                break;
            case 9:
                location = new Location { Country = "Turkey", City = "Ankara", AirlineCompany = "Esenboğa Airlines", IsWorking = true };
                break;
            case 10:
                location = new Location { Country = "France", City = "Lyon", AirlineCompany = "Air France", IsWorking = true };
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }

        if (location != null)
        {
            Console.WriteLine($"You have selected {location.City}, {location.Country}. The airline company operating in this location is {location.AirlineCompany} and it is currently {(location.IsWorking ? "working" : "not working")}.");
        }
        lastlocation = new Location
        {
            City = location.City,
            Country = location.Country,
            AirlineCompany = location.AirlineCompany,
            IsWorking = location.IsWorking
        };
        
    }

    static void SelectDate()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan; // Set the text color to green

        Console.WriteLine("Possible locations:");
        Console.WriteLine("1. 16 mayis 2023 15.00");
        Console.WriteLine("2. 17 mayis 2023 15.00");
        Console.WriteLine("3. 17 mayis 2023 19.00 ");
        Console.WriteLine("4. 19 mayis 2023 21.00 ");
        Console.WriteLine("5. 14 mayis 2023 12.00 ");
        Console.WriteLine("6. 12 mayis 2023 5.00");
        Console.WriteLine("7. 26 mayis 2023 9.00");
        Console.WriteLine("8. 28 mayis 2023 15.00");
        Console.WriteLine("9. 6 mayis 2023 1.00");
        Console.WriteLine("10.17 mayis 2023 17.00");

        Console.Write("Select a location by entering its number: ");
        int selection = int.Parse(Console.ReadLine());

        Date date = null;
        switch (selection)
        {
            case 1:

                date = new Date
                {
                    ay = "Mayis",
                    Gun = 16,
                    yil = 2023,
                    time = 15.00,
                };
                
                
                break;
            case 2:

                date = new Date
                {
                    ay = "Mayis",
                    Gun = 17,
                    yil = 2023,
                    time = 19.00,
                };
                
                break;
            case 3:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 17,
                    yil = 2023,
                    time = 19.00,
                };
               
                break;
            case 4:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 19,
                    yil = 2023,
                    time = 21.00,
                };
                
                break;
            case 5:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 14,
                    yil = 2023,
                    time = 12.00,
                };
              
                break;
            case 6:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 12,
                    yil = 2023,
                    time = 5.00,
                };
              
                break;
            case 7:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 26,
                    yil = 2023,
                    time = 9.00,
                };
               
                break;
            case 8:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 28,
                    yil = 2023,
                    time = 15.00,
                };
               

                break;
            case 9:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 6,
                    yil = 2023,
                    time = 1.00,
                };
             
                break;
            case 10:
                date = new Date
                {
                    ay = "Mayis",
                    Gun = 17,
                    yil = 2023,
                    time = 17.00,
                };
             
            

                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }

        if (date != null)
        {
            Console.WriteLine($"{date.yil} - cu yil, {date.ay} ayinin {date.Gun} -da  saat {date.time}.00 sectiniz ");
            };
        lastdate = new Date
        {
            ay = date.ay,
            yil = date.yil,
            Gun = date.Gun,
            time = date.time

        };
       
    }
    static void KoltukSecimiYap()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta; // Set the text color to green

        Console.WriteLine("Koltuk seçiminizi yapın:");

        Console.WriteLine("Koltuk numarası: 1. Cam Kenari ");
        Console.WriteLine("Koltuk numarası: 2. Orta kisim");
        Console.WriteLine("Koltuk numarası: 3.Koridor tarafi");
        int secilenKoltuk = int.Parse(Console.ReadLine());

        switch (secilenKoltuk)
        {
            case 1:
                secilenKoltuk = 1;
                koltuktipi = " Cam Kenari ";
                Console.WriteLine($"Koltuk numarası: {secilenKoltuk}");
                tutar = 1500;
                break;
            case 2:
                secilenKoltuk = 2;
                koltuktipi = " Orta Kisim ";
                Console.WriteLine($"Koltuk numarası: {secilenKoltuk}");
                tutar = 1000;
                break;
            case 3:
                secilenKoltuk = 3;
                koltuktipi = "Koridor Tarafi";
                Console.WriteLine($"Koltuk numarası: {secilenKoltuk}");
                tutar = 500;
                break;
            default:
                Console.WriteLine("Gecersiz secim!");
                break;
        }

       int sonkoltuk = secilenKoltuk;
       
    }
    static void OdemeYap()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow; // Set the text color to green

        // Ödeme tutarını 500 TL olarak ayarlıyoruz


        Console.WriteLine($"Ödeme tutarı: {tutar} TL");

        // Ödeme bilgilerini istiyoruz

       
        bool temp = true;
        while (temp){
            Console.Write("Odeme tipini giriniz 1.Kredi kartı / 2.Banka karti: ");
            int odemeTipi = int.Parse(Console.ReadLine());
            switch (odemeTipi)
            {
                case 1:
                    Console.WriteLine("Kredi kartıyla odeme seçimi başarılı!");
                    temp = false;
                    break;
                case 2:
                    Console.WriteLine("Banka karti odeme seçimi başarılı!");
                    temp = false;
                    break;
                default:
                    Console.WriteLine("Gecerli odeme tipi giriniz.");
    
                break;
            }
        }
            
            
            
            temp = true;
            while (temp) {
                    Console.Write("Kart numarasını giriniz: ");
                    string kartNo = Console.ReadLine();
                    int size = kartNo.Length;

                    if (size == 16)
                            {
                                string acceptedKartNo = kartNo;
                                Console.WriteLine("Kart Numarası Geçerli !");
                                Console.WriteLine(acceptedKartNo);
                                temp = false;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz Kart Numarası !");
                                if (size > 16)
                                {
                                    Console.WriteLine("Kart numarasi 16 rakamdan fazla karakter icermemelidir!");
                                }
                                else if (size < 16)
                                {
                                    Console.WriteLine("Kart numarasi 16 rakamdan az karakter icermemelidir!");
                                }

                            }
                }
      
        
        temp = true;
        while (temp)
        {
            Console.WriteLine("cvv kodunu giriniz: ");
            string cvv = Console.ReadLine();
            int size2 = cvv.Length;
                if (size2 == 3)
                {
                    string acceptedCvv = cvv;
                    Console.WriteLine("Gecerli cvv kodu !");
                    Console.WriteLine(acceptedCvv);
                    temp = false;
                }
               else
                {
                    Console.WriteLine("Gecersiz cvv kodu.");
                    if (size2 > 3)
                    {
                        Console.WriteLine("cvv 3 rakamdan fazla karakter icermemelidir!");
                    }
                    else if (size2 < 3)
                    {
                        Console.WriteLine("cvv 3 rakamdan az karakter icermemelidir!");
                    }

            }
        }

        temp = true;
        while (temp)
        {
            Console.Write("kartın son kullanma tarihini giriniz: ");
            string sonTarihi = Console.ReadLine();
            int size3 = sonTarihi.Length;
                if (size3 == 4)
                {
                    string acceptedsonkullanmaTarihi = sonTarihi;
                    Console.WriteLine("Gecerli son kullanma tarihi ");
                    Console.WriteLine(acceptedsonkullanmaTarihi);
                    temp = false;
                }
                else
                {
                    Console.WriteLine("Gecersiz son kullanma tarihi.");
                    if (size3 > 4)
                    {
                        Console.WriteLine("son kullanma tarihi 4 rakamdan fazla karakter icermemelidir!");
                    }
                    else if (size3 < 4)
                    {
                        Console.WriteLine("son kullanma tarihi 4 rakamdan az karakter icermemelidir!");
                    }

            }
        }

        // Ödeme işlemini gerçekleştiriyoruz
        Console.WriteLine("Ödeme başarıyla gerçekleştirildi.");

        // Rezervasyon bilgilerini detaylı bir şekilde gösteriyoruz
        }

    static void DetayBilgi()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed; // Set the text color to green

        Console.WriteLine($"Siz {lastUser.Name} {lastUser.Surname} ({lastUser.Age}) basariyla rezervasyon yaptiniz.");
        Console.WriteLine($"Ucak biletiyle ilgili detaylar {lastUser.Email} e-posta adresinize yollanacaktir. ");
        Console.WriteLine("Tarih bilgileri:");
        Console.WriteLine($"{lastdate.Gun}/{lastdate.ay}/{lastdate.yil},Saat: {lastdate.time}");
        Console.WriteLine("Konum bilgileri:");
        Console.WriteLine($"{lastlocation.City}/{lastlocation.Country},{lastlocation.AirlineCompany}");
        Console.WriteLine("Sectiginiz koltuk: " + koltuktipi );
        Console.WriteLine("Odeme tutari: " + tutar);

    }
   
}


    

