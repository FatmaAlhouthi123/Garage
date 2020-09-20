using System;
using System.Collections.Generic;
using System.Text;

namespace Garage {
    class Car : Vehcle {


        public int Number_of_seats { get; set; }

        public Car(int registerNo, string color, int WheelsNo, int number_of_seats) : base(registerNo, color, WheelsNo) {
            this.Number_of_seats = number_of_seats;
            this.VehcleType = V_Type.car;

        }





    }
}
