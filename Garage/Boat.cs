using System;
using System.Collections.Generic;
using System.Text;

namespace Garage {
    class Boat : Vehcle {

        public int Lenght { get; set; }


        public Boat(string registerNo, string color, int WheelsNo, int lenght) : base(registerNo, color, WheelsNo) {
            this.Lenght = lenght;
            this.VehcleType = V_Type.boat;
          



        }





    }
}
