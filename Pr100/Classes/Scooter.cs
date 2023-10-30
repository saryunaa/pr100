using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr100.Classes
{
    class Scooter : Transport
    {
        public string NumberOfWheels { get; set; }
        public string Engine { get; set; }
        public new bool IsRented { get; set; }

        public Scooter(string speed, string color, string model, string licenseCategory, string numberOfWheels, string engine, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            NumberOfWheels = numberOfWheels;
            Engine = engine;
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Scooter: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Number of Wheels: {NumberOfWheels}, Engine: {Engine}, Is Rented: {(IsRented ? "Yes" : "No")}");
        }
    }
}
