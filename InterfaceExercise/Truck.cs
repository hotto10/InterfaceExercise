using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : ICompany , IVehicle
    {
        public string BedSize { get; set; }

        public bool LiftGate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public double Cylinders { get; set; }
        public string Model { get; set; }
        public string SeatCount { get; set; }
        public string Make { get; set; }
    }

    //public static class MyExtensions
    //{
    //    public static IVehicle Transform<T>(this IVehicle sender) where T : IVehicle
    //    {
    //        if (sender == null)
    //            return default(IVehicle);
    //        var vehicle = (T)sender;
    //        return (T)sender;
    //    }
    //}
}
