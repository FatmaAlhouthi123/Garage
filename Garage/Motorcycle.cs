using System;
using System.Collections.Generic;
using System.Text;

namespace Garage {
    class Motorcycle : Vehcle {
       public int Cylinder_volume { get; set; }


        public Motorcycle(string registerNo, string color, int WheelsNo, int cylinder_volume) : base(registerNo, color, WheelsNo) {
            this.Cylinder_volume = cylinder_volume;
            this.VehcleType = V_Type.motorcycle;
        }

    }
}






