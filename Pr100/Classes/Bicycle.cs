using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr100.Classes
{
    class Bicycle : Transport
    {
        public new bool IsRented { get; set; }
        public Bicycle(string speed, string color, string model, string licenseCategory, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Bicycle: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Is Rented: {(IsRented ? "Yes" : "No")}");
        }
    }
}
