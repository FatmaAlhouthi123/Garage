using System;
using System.Linq;

namespace Garage {
    class Program {
        static void Main(string[] args) {





            Console.WriteLine(" *************************************   Welcome to garage   ************************************* ");



            Garage_Manager gm = new Garage_Manager();
            gm.Default_vehcles_in_garage();

            bool inLoop = true;

            garage_handler gh = new garage_handler();




            while (inLoop)
            {

                Console.WriteLine("\n What do you want to do? type number from 1 to 5\n");

                Console.WriteLine("  1)- get total Parking spaces \n  2)- add vehcle \n  3)- remove vehcle ");
                Console.WriteLine("  4)- get number of vacant Parking spaces \n  5)- get number of populated Parking spaces " +
                    " \n  6)-get ifo om vehcle in garage and number of them   \n  0)- to close application\n");
                Console.WriteLine(" ************************************************************************************************** \n");

                int chooice = int.Parse(Console.ReadLine());
                switch (chooice)
                {

                    case 1:
                        {
                            Console.WriteLine($" There are {gm.Naumber_of_total_parkingSpaces()} parkering spaces in garage.");
                        }
                        break;



                    case 2:
                        {
                            try
                            {
                                gh.Add_vehcle_to_Garage();
                            }
                            catch (FormatException e) { Console.WriteLine(e.Message); }
                            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }


                        }
                        break;


                    case 3:
                        {
                            try
                            {
                                gh.Remove_vehcle_from_Garage();
                            }
                            catch (FormatException e) { Console.WriteLine(e.Message); }
                            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }
                        }
                        break;



                    case 4:
                        {

                            gm.Free_parkingSpaces();
                        }
                        break;



                    case 5:
                        {
                            Console.WriteLine(gm.Number_of_vehcle_in_garage());

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
