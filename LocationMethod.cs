internal class LocationMethod
{

    static void SelectLocation()
    {
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
            //
            case 1:

                // surda bitiyor locasyonu da istersen kopyala ama icerige ekstra dikkat
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


    }
}