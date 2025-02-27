//written by Holbrait
//2/23/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Vehicle
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} with {NumberOfDoors} doors";
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar)
            : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} (Has Sidecar: {HasSidecar})";
        }
    }

    

}

