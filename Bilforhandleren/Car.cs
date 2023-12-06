namespace Bilforhandleren
{



    internal class Car
    {
        public string Logo{get;set;}
        public int Year{get;set;}
        public double KM{get;set;}
        public string Regnr{get;set;}
        public double Price { get;set;}
           
        public void ShowInfo(Dealership dealership)
        {
            Console.WriteLine($"Merke:{Logo}, Årsmodell:{Year}, Kilometer:{KM}, Registreringsnummer:{Regnr}");
            Console.WriteLine($"Vil du kjøpe bilen for {Price},-?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "ja")
            {
                dealership.Sellcar(this, new Customer("Bent", 299, 002));
            }
            else
            {
                Console.WriteLine("Fuck");
            }
        }

        public Car(string logo, int year, double km, string regnr, double price)
        {
            Logo = logo;
            Year = year;
            KM = km;
            Regnr = regnr;
            Price = price;
        }
    }
} 

