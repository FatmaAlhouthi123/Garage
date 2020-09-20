using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Garage {


    class GarageClass<T> : IEnumerable<T> where T : IVehcle {

        public static T[] garage_Array = new T[10];

        static int  vehcle_in_garage = 0;
        static int total_parkingSpaces = 10;
        static int free_parkingSpaces = total_parkingSpaces - parkingSpaces_in_use;
        static int parkingSpaces_in_use = 0;


        public static int Vehcle_in_garage { get { return vehcle_in_garage; } set { vehcle_in_garage = value; } }
        public static Array Garage_Array { get; set; }
        public static int Total_parkingSpaces { get { return total_parkingSpaces; } }
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

            garage_Array[vehcle_in_garage] = objekt;

           // Console.WriteLine(objekt.ToString());
           // Console.WriteLine(garage_Array[vehcle_in_garage].ToString());

            vehcle_in_garage++;
            free_parkingSpaces--;
            ParkingSpaces_in_use++;

        }

      


            public static void Remove_vehcle_f_Garage() {

            vehcle_in_garage--;
            free_parkingSpaces++;
            ParkingSpaces_in_use--;

        }



        public void AllVehcle_in_garag() {

            Console.WriteLine( $" There is {vehcle_in_garage} in the Garage ");
            int i = 1;
            foreach (var v in garage_Array)
            {
                if (v != null) { 
                Console.WriteLine($"{i}- Type = {v.VehcleType}, Register Number = {v.RegisterNumber}");
                i++;
            }
            }
        }

    }
}
