using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr100.Classes
{
    class Boat : Transport
    {
        public string Engine { get; set; }
        public new bool IsRented { get; set; }
        public Boat(string speed, string color, string model, string licenseCategory, string engine, bool isRented)
            : base(speed, color, model, licenseCategory, isRented)
        {
            Engine = engine;
            IsRented = isRented;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Boat: {Model}, Speed: {Speed}, Color: {Color}, License Category: {LicenseCategory}, Is Rented: {(IsRented ? "Yes" : "No")}| Engine: {(Engine)}");
        }
    }
}
