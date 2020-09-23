using System;
using System.Collections.Generic;
using System.Text;

namespace Garage {
    class Garage_Manager {


        GarageClass<IVehcle> garage = new GarageClass<IVehcle>();


        public int Number_of_vehcle_in_garage() {
            return GarageClass<IVehcle>.Vehcle_in_garage;
        }

        public int Naumber_of_total_parkingSpaces() {
            return GarageClass<IVehcle>.Total_parkingSpaces;
        }

        public int Free_parkingSpaces() {
            return GarageClass<IVehcle>.Free_ParkingSpaces;
        }

        public void Default_vehcles_in_garage() {


            garage.Populate_Garage(new Bus("12345", "white", 12, FuelType.Diesel));
            garage.Populate_Garage(new Car("5468544", "red", 4, 7));
            garage.Populate_Garage(new Airplane("564684", "white", 2, 2));
            garage.Populate_Garage(new Boat("564684", "white", 2, 50));
            garage.Populate_Garage(new Car("55598", "black", 4, 4));
            garage.Populate_Garage(new Airplane("546545", "blue", 2, 4));
            garage.Populate_Garage(new Bus("44448", "green", 8, FuelType.Gasoline));
            garage.Populate_Garage(new Motorcycle("772201", "yellow", 2, 14));
        }





        public void All_Vehcle_in_garag() {

            garage.AllVehcle_in_garag();

        }
        
    }
}