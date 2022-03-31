using System;
using Models;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;

            Console.WriteLine("Mashin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            Car[] cars = new Car[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. mashinin brendini daxil edin:");
                string brand = Console.ReadLine();
                Console.WriteLine($"{i + 1}. mashinin rengini daxil edin:");
                string color = Console.ReadLine();
                Console.WriteLine($"{i + 1}. mashinin millage-ini daxil edin:");
                int millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}. mashinin cari benzinini daxil edin:");
                int currentFuel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bu mashin 1km-e ne qeder benzin serf edir?");
                int fuelFor1km = Convert.ToInt32(Console.ReadLine());
                cars[i] = new Car()
                {
                    Brand = brand,
                    Color = color,
                    Millage = millage,
                    CurrentFuel = currentFuel,
                    FuelFor1km = fuelFor1km
                };
            }

            while (check)
            {
                Console.WriteLine("===============MENU==================");
                Console.WriteLine("Emeliyyati secin(1, 2 ve ya 3):");
                Console.WriteLine(" 1. Mashınlari millage-e gore filtrle \n 2.Butun mashinlari goster \n 3.Prosesi bitir");
                Console.WriteLine("=====================================");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Filtrlemek ucun minimum millage deyerini daxil edin:");
                        int minMillage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Filtrlemek ucun maximum millage deyerini daxil edin:");
                        int maxMillage = Convert.ToInt32(Console.ReadLine());
                        FilterForMillage(cars, minMillage, maxMillage);
                        break;

                    case 2:
                        ShowAllCars(cars);
                        break;

                    case 3:
                        check = false;
                        break;

                    default:
                        break;
                }
            }
        }
        static void FilterForMillage(Car[] cars, int minMillage, int maxMillage)
        {
            foreach (var item in cars)
            {
                if (item.Millage >= minMillage && item.Millage <= maxMillage)
                {
                    item.ShowInfo();
                }
            }
        }
        static void ShowAllCars(Car[] cars)
        {
            foreach (Car item in cars)
            {
                item.ShowInfo();
            }
        }
    } 
}
