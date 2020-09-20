using System;
using System.Linq;

namespace Garage {
    class Program {
        static void Main(string[] args) {
            bool inLoop = true;

            garage_handler gh = new garage_handler();
            Garage_Manager gm = new Garage_Manager();
           
            gm.Default_vehcles_in_garage();
           
            
            GarageClass<IVehcle> garage = new GarageClass<IVehcle>();


            Console.WriteLine(" *************************************Welcome to garage************************************* ");


            //int reg_no = 0;     // delet

            //    bool reg_No_Validation = true;








            //        foreach (IVehcle vehcle in garage)

            //    {

            //                Console.WriteLine("again");
            //    if (vehcle is null) { Console.WriteLine("null"); }

            //        else
            //        {
            //            if (vehcle.RegisterNumber == reg_no)

            //            {
            //                reg_No_Validation = true;
            //                Console.WriteLine($"reg_No_Validation {reg_No_Validation}  &reg_no {reg_no} ");
            //            }

            //            else
            //            { reg_No_Validation = false; Console.WriteLine("vehcle.RegisterNumber != reg_no"); }
            //        }


            //    }







            //DEL

            while (inLoop) {

                Console.WriteLine("\n What do you want to do? type number from 1 to 5"); 
            Console.WriteLine(" 1- get total Parking spaces   2- add vehcle   3- remove vehcle ");
            Console.WriteLine("4- get number of vacant Parking spaces  5- get number of populated Parking spaces " +
                " \n 6-get ifo om vehcle in garage and number of them     0- to close application\n");
                Console.WriteLine(" *************************************************************************** \n");

                int chooice = int.Parse(Console.ReadLine());
                switch (chooice)
                {

                    case 1:
                        {
                            Console.WriteLine(gm.Naumber_of_total_parkingSpaces());
                        }
                        break;



                    case 2:
                        {
                            gh.Add_vehcle_to_Garage();


                        }
                        break;


                    case 3:
                        {
                            gh.Remove_vehcle_from_Garage();

                        }
                        break;



                    case 4:
                        {

                            gm.Free_parkingSpaces();
                        }
                        break;



                    case 5:
                        {
                            gm.Number_of_vehcle_in_garage();

                        }
                        break;


                        
                    case 6:
                        {
                            gm.All_Vehcle_in_garag();

                        }
                        break;


                    case 0:
                        {
                            inLoop = false;

                        }
                        break;



                    default:
                        {
                            Console.WriteLine(" plz choose number between 1 - 5");


                        }
                        break;

                       


                }












    









            }

        }
    }
}
