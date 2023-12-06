namespace Bilforhandleren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ferrari", 1998, 230104.2, "AE 39402", 30);
            Car car2 = new Car("Lambo", 1999, 220104.2, "AZ 39402", 50);
            Customer customer1 = new Customer("Bjarne", 1000, 001);
            Dealership dealer1 = new Dealership("Autoxo", "10:00", "Bjarnar Stein Gate 10", "20:00");

          
            dealer1.Inventory.Add(car);
            dealer1.Inventory.Add(car2);

            dealer1.Welcome();
        }
    }
}
/*
    Bilforhandleren
    En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell,
    registreringsnummer og kilometerstand. Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa,
    eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand.
    Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.
*/

//Biler: 
//merke, årsmodell, regnr, km

//Kunder:
//Kjøp av bil
//"inventory"

//Forhandler:
//Respons
//"inventory"

//Filter
//Årsmodell og KM
//Ekstra: filtre etter merke