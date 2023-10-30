using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr100.Classes
{
    class Car : Transport
    {
        public string NumberOfWheels { get; set; }
        public string Engine { get; set; }
        public new bool IsRented { get; set; }
        public Car(string speed, string color, string model, string licenseCategory, string numberOfWheels, string engine, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            NumberOfWheels = numberOfWheels;
            Engine = engine;
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Car: {Model}| Speed: {Speed}| Color: {Color}| License Category: {LicenseCategory}| Is Rented: {(IsRented ? "Yes" : "No")}| Number of Wheels: {NumberOfWheels}");
        }
    }
}
