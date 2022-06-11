using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class VehicleBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        public VehicleBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._vehicle = new Vehicle();
        }

        public void AddECU()
        {
            this._vehicle.Add("ECU");
        }

        public void AddEngine()
        {
            this._vehicle.Add("Engine");
        }

        public void AddNavigationSystem()
        {
            this._vehicle.Add("Navigation System");
        }

        public void AddSeats()
        {
            this._vehicle.Add("Seats");
        }

        public void AddTires()
        {
            this._vehicle.Add("Tires");
        }

        public void Build()
        {
            Console.WriteLine("Building...");
        }

        public Vehicle GetVehicle()
        { 
            Vehicle vehicle = this._vehicle;
            this.Reset();
            return vehicle;
        }
    }
}
