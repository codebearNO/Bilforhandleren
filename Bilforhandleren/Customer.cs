namespace Bilforhandleren
{
    internal class Customer
    {
        public string Name{get; set;}
        public List<Car> ownCar = new List<Car>();
        public double Cash{get; set;}
        public int Id{get; set;}

        public void Showinfo()
        {
            Console.WriteLine($"Navn:{Name} Penger:{Cash} ID:{Id}, Biler: {ownCar[0].Logo}");
        }

        public Customer(string name, double cash, int id)
        {
            Name = name;
            Cash = cash;
            Id = id;
        }

        public void BuyCar(Car car, Dealership dealership)
        { 
            if(Cash >= car.Price)
            {
                ownCar.Add(car);
                dealership.Inventory.Remove(car);
                Cash -= car.Price;
                Console.WriteLine($"{Name} har kjøpt en {car.Logo}");

            }
            else
            {
                Console.WriteLine($"{Name} har ikke nok penger til å kjøpe bil.");
            }
        }
    }
}
