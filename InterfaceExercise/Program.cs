using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ToDos

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            #endregion
            var car1 = new Car()
            {
                CompanyName = "Ford Automotive",
                CompanyLogo = "Pony",
                Make = "Ford",
                Model = "Mustang",
                SeatCount = "5",
                Cylinders = 6.0d,
                Trunk = true,
                SunglassHolder = true
            };

            var truck1 = new Truck() 
            {
                CompanyName = "Cheverlot", 
                CompanyLogo = "Cicle", 
                Make = "Chevy", 
                Model = "Silverado", 
                SeatCount = "6",
                Cylinders = 8.0d, 
                BedSize = "Huge", 
                LiftGate = true 
            };

            var suv1 = new SUV() 
            { 
                CompanyName = "Cadillac Auto", 
                CompanyLogo = "rectangle",
                Make = "Cadillac", 
                Model = "Escalade",
                SeatCount = "7", 
                Cylinders = 8.0d, 
                CargoHoldSize = "Medium",
                SlidingDoors = true 
            };

            var carList = new List<IVehicle>();

            carList.Add(car1);
            carList.Add(truck1);
            carList.Add(suv1);

            foreach (var car in carList)
            {
                DisplayVehicleInfo(car);
                
            }
           
        }

        static void DisplayVehicleInfo(IVehicle vehicle)
        {
            if (vehicle == null)
                return;
            
            if (vehicle is Car)
            {
                Car car = (Car)vehicle;
                Console.WriteLine($"Dealership Name: {car.CompanyName}, Company Logo: {car.CompanyLogo}, Make: {car.Make}, Model: {car.Model}, How many cyclinders: {car.Cylinders}, Seat Count: {car.SeatCount}, Sunglass Holder:{car.SunglassHolder}, Has Trunk: {car.Trunk}");
            }
            else if (vehicle is SUV)
            {
                SUV car = (SUV)vehicle;
                Console.WriteLine($"Dealership Name: {car.CompanyName}, Company Logo: {car.CompanyLogo}, Make: {car.Make}, Model: {car.Model}, How many cyclinders: {car.Cylinders}, Seat Count: {car.SeatCount}, Sliding Doors: {car.SlidingDoors}, Cargo Size:{car.CargoHoldSize} ");
            }
            else if (vehicle is Truck)
            {
                Truck car = (Truck)vehicle;
                Console.WriteLine($"Dealership Name: {car.CompanyName}, Company Logo: {car.CompanyLogo}, Make: {car.Make}, Model: {car.Model}, How many cyclinders: {car.Cylinders}, Seat Count: {car.SeatCount}, Lift Gate: {car.LiftGate}, Bed Size: {car.BedSize}");
            }
        }
    }
}
