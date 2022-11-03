using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : ICompany , IVehicle
    {
        public string CargoHoldSize { get; set; } = "large";

        public bool SlidingDoors { get; set; } = true;
        public string CompanyName { get; set; } = "Hyundai Auto";
        public string CompanyLogo { get; set; } = "circle emblem";
        public double Cylinders { get; set; } = 4.0d;
        public string Model { get; set; } = "Kona";
        public string SeatCount { get; set; } = "5";
        public string Make { get; set; } = "Hyundai";
    }
}
