using System;
namespace Models
{
    public class Car:Vehicle
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public int FuelFor1km { get; set; }
        public int Distance { get; set; }

        public override void Drive()
        {
            if (CurrentFuel>= Distance * FuelFor1km)
            {
                CurrentFuel -= FuelFor1km;
                Millage++;
            }
            else
            {
                Console.WriteLine("Mashina benzin vurun!");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Color: {Color}, Current fuel: {CurrentFuel}, Millage: {Millage}, Fuel for 1 km: {FuelFor1km}");
        }
    }
}
