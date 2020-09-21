using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Garage {
    class Vehcle : IVehcle {

        public string RegisterNumber { get; set; }
        public string Color { get; set; }
        public int WheelsNumber { get; set; }
        public V_Type VehcleType { get; set; }


        public Vehcle(string registerNo, string color, int WheelsNo) {
            this.RegisterNumber = registerNo;
            this.Color = color;
            this.WheelsNumber = WheelsNo;

        }

       
    }
}
