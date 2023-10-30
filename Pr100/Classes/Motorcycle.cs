using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr100.Classes
{
    class Motorcycle : Transport
    {
        public string NumberOfWheels { get; set; }
        public string Engine { get; set; }
        public new bool IsRented { get; set; }

        public Motorcycle(string speed, string color, string model, string licenseCategory, string numberOfWheels, string engine, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            NumberOfWheels = numberOfWheels;
            Engine = engine;
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Motorcycle: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Number of Wheels: {NumberOfWheels}, Engine: {Engine}, Is Rented: {(IsRented ? "Yes" : "No")}");
        }
    }
}
