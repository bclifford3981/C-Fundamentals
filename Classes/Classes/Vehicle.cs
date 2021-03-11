using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceships, Planes, Boats }


    public class Vehicle
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; private set; }
        public Vehicle()
        {

        }

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOff();
        }
        public void IndicateLeft()
        {
            LeftIndicator.FlashOn();
            RightIndicator.FlashOff();
        }
        public void Hazards()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOn();
        }
        public void ClearIndicators()
        {
            RightIndicator.FlashOff();
            LeftIndicator.FlashOff();
        }
    }
    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void FlashOn()
        {
            IsFlashing = true;
            Console.WriteLine("Vehicle is flashing.");
        }
        public void FlashOff()
        {
            IsFlashing = false;
            Console.WriteLine("Vehicle is not flashing.");

        }
    }
}
