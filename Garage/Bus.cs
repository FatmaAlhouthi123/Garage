using System;
using System.Collections.Generic;
using System.Text;

namespace Garage {

    public enum FuelType { Gasoline, Diesel }
    class Bus :  Vehcle {
        public FuelType FuelType { get; set; }

        //

        public Bus(string registerNo, string color, int WheelsNo, FuelType fuel_t) : base(registerNo, color, WheelsNo) {
            this.FuelType = fuel_t;
            this.VehcleType = V_Type.bus;

        }




    }

}