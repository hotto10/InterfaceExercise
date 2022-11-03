using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany 
    {
        public double Cylinders { get; set; }
        public string Model { get; set; }
        public string SeatCount { get; set; }
        public string Make { get; set; }
    }
}
