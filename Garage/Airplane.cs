using System;
using System.Collections.Generic;
using System.Text;

namespace Garage {
    class Airplane : Vehcle {

        public int Number_of_Engines { get; set; }

        public Airplane(string registerNo, string color, int WheelsNo, int number_of_Engines) : base(registerNo, color, WheelsNo) {
            this.Number_of_Engines = number_of_Engines;
            this.VehcleType = V_Type.airplane;


        }






    }
}
