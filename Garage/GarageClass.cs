using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Garage {


    class GarageClass<T> : IEnumerable<T> where T : IVehcle {

        static T[] garage_Array = new T[10];

        static int  vehcle_in_garage = 0;
        static int total_parkingSpaces = 10;
        static int free_parkingSpaces = Total_parkingSpaces - ParkingSpaces_in_use;
        static int parkingSpaces_in_use = 0;

        public GarageClass() {
            Garage_Array = garage_Array;
        }
        public static int Vehcle_in_garage { get { return vehcle_in_garage; } set { vehcle_in_garage = value; } }
        public static Array Garage_Array { get; set; }
        
        public static int Total_parkingSpaces { get { return total_parkingSpaces; } set { total_parkingSpaces = value; } }
        public static int Free_ParkingSpaces { get { return free_parkingSpaces; } set { free_parkingSpaces = value; } } 
        public static int ParkingSpaces_in_use { get { return parkingSpaces_in_use; } set { parkingSpaces_in_use = value; } } 
        
String Vehcle_type { get; set; }

        public IEnumerator<T> GetEnumerator() {
            foreach (var vehcle in garage_Array)
            {
                yield return vehcle;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }





        public void Populate_Garage(T objekt) {
           
            garage_Array[Vehcle_in_garage] = objekt;
 
           Add_vehcle_f_Garage();
        }




        public static void Remove_vehcle_f_Garage() {


            Free_ParkingSpaces++;
            ParkingSpaces_in_use--;
            Vehcle_in_garage--;

        }


        public static void Add_vehcle_f_Garage() {
            Free_ParkingSpaces--;
            ParkingSpaces_in_use++;
            Vehcle_in_garage++;

        }



        public void AllVehcle_in_garag() {

            Console.WriteLine( $" There is {Vehcle_in_garage} in the Garage ");
            int i = 1;
            foreach (IVehcle v in Garage_Array)
            {
                if (v != null) { 
                Console.WriteLine($"{i}- Type = {v.VehcleType}, Register Number = {v.RegisterNumber}");
                i++;
            }
            }
        }

    }
}
