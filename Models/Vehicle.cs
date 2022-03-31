using System;
namespace Models
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Color: {Color}, Millage: {Millage}");
        }

        public abstract void Drive();
    }
}
