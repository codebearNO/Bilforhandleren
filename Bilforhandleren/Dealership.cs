using System.ComponentModel.Design;

namespace Bilforhandleren
{
    internal class Dealership
    {
        public string Name{get; set;}
        public string OpenTime{get; set;}
        public string Adress{get; set;}
        public string CloseTime{get; set;}
        public List<Car> Inventory = new List<Car>();

        public void ShowInfo() 
        {
            Console.WriteLine($"Navn:{Name} Åpningstid:{OpenTime} Adresse:{Adress} Stengetid:{CloseTime} Eier:{Inventory[0].Logo}");
        }

        public void Welcome()
        {
            Console.WriteLine($"Velkommen til {Name}");
            Console.WriteLine($"Vi har mange forskjellige biler til salgs: ");
            ListCars();
            MyMenu();
        }

        private void MyMenu()
        {
            Console.Write("Hvilken bil vil du se på?");
            string? answer = Console.ReadLine();
            ShowCar(answer);
        }

        private void ShowCar(string? answer)
        {
            int intAnswer = Convert.ToInt32(answer);
            Inventory[intAnswer - 1].ShowInfo(this);
        }

        private void ListCars()
        {
            var i = 1;
            foreach (var car in Inventory)
            {
                Console.WriteLine($"{i}) {car.Logo}, {car.Price},-");
                i++;
            }
        }

        public Dealership(string name, string openTime, string adress, string closeTime)
        {
            Name = name;
            OpenTime = openTime;
            Adress = adress;
            CloseTime = closeTime;
        }

        public void Sellcar(Car car, Customer customer)
        {
            if ((Inventory.IndexOf(car) != -1) && customer.Cash >= car.Price)
            {
                Inventory.Remove(car);
                customer.ownCar.Add(car);
                customer.Cash -= car.Price;
                Console.WriteLine($"{customer.Name} har kjøpte en {car.Logo} fra {Name}.");
            }
            else if (Inventory.IndexOf(car) != -1)
            {
                Console.WriteLine("Kunden har ikke nok penger.");
            }
            else
            {
                Console.WriteLine("Vi har ikke denne bilen inne for øyeblikket.");
            }
         
        }
    }
    
}
