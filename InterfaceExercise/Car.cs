using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public bool Trunk { get; set; } = true;

        public bool SunglassHolder { get; set; } =true;
        public string CompanyName { get; set; } = "Ford Automotive";
        public string CompanyLogo { get; set; } = "Pony";
        public double Cylinders { get; set; } = 6.0d;
        public string Model { get; set; } = "Mustang";
        public string SeatCount { get; set; } = "5";
        public string Make { get; set; } = "Ford";

        
    }
}
