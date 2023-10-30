using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr100.Classes
{
    abstract class Transport
    {
        public string Speed { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string LicenseCategory { get; set; }
        public bool IsRented { get; set; }

        public Transport(string speed, string color, string model, string licenseCategory, bool isRented)
        {
            Speed = speed;
            Color = color;
            Model = model;
            LicenseCategory = licenseCategory;
            IsRented = isRented;
        }

        protected Transport(string speed, string color, string model, string licenseCategory)
        {
            Speed = speed;
            Color = color;
            Model = model;
            LicenseCategory = licenseCategory;
        }

        public abstract void PrintInfo();
    }
}
