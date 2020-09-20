using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Garage {
    class garage_handler : UI {

        GarageClass<IVehcle> garage = new GarageClass<IVehcle>();

        V_Type fordon_type;
        FuelType fuelType;
        int reg_no;
        string color;
        int wheels_no;
        int number_of_seats;
        int number_of_Engines;
        int cylinder_volum;
        int length;


        public void Add_vehcle_to_Garage() {

            garage.Populate_Garage(Creat_vehcle());

        }


        public void Remove_vehcle_from_Garage() {

            Console.WriteLine("Enter register Number for vehcle that you want to take out of garage ");

            reg_no = int.Parse(Console.ReadLine());

            if (Check_reg_No())
                for (int i = 0; i < garage.ToArray().Length; i++)
                {
                    if (garage.ToArray()[i] != null)
                    {
                        Console.WriteLine("reeeem");
                        Console.WriteLine(garage.ToArray()[i].RegisterNumber == reg_no);

                    if (garage.ToArray()[i].RegisterNumber == reg_no) {
                            ////   garage.ToArray()[i] = default;




                            Console.WriteLine(" removed" + garage.ToArray()[i].ToString());
                        }





                        

                    GarageClass<IVehcle>.Remove_vehcle_f_Garage();
                }
                }

        }



        public bool Check_reg_No() {

            bool reg_No_Validation = true;

            foreach (var vehcle in garage)
            {
                if (vehcle is null) {
                    //del
                    Console.WriteLine("null");
                    //del
                    reg_No_Validation = false;
                    continue;
                }
                   
                else if (vehcle.RegisterNumber == reg_no)

                    {
                        reg_No_Validation = true;
                        Console.WriteLine($" the reg number that you choosed is existed in garage  ");
                    break;
                    }

                    else
                    { reg_No_Validation = false; Console.WriteLine("vehcle.RegisterNumber != reg_no"); }
                }


            
            return reg_No_Validation;
        }


        public void vehcle_info() {

            bool inLoop = true;
            while (inLoop)
            {

                Console.WriteLine("enter vehcle regerstration no");
                reg_no = int.Parse(Console.ReadLine());

                if (Check_reg_No())
                    Console.WriteLine("reg No is exist please enter another reg No");
                else
                    inLoop = Check_reg_No();  // altstå false
            }


            Console.WriteLine("enter vehcle color");
            color = Console.ReadLine();

            Console.WriteLine("enter vehcle wheels no");
            wheels_no = int.Parse(Console.ReadLine());

            Console.WriteLine("choose vehcle type  1- car  2- airplane  3-bus  4-boat  5-motorcycle");
            int choose2 = int.Parse(Console.ReadLine());
            switch (choose2)
            {

                case 1:
                    {
                        fordon_type = V_Type.car;
                        
                        Console.WriteLine("how many seats in the car?");
                        number_of_seats = int.Parse(Console.ReadLine());
                    }
                    break;

                case 2:
                    {
                        fordon_type = V_Type.airplane;
                        Console.WriteLine("how many engines in the airplane?");
                        number_of_Engines = int.Parse(Console.ReadLine());
                    }
                    break;

                case 3:
                    {
                        fordon_type = V_Type.bus;
                        Console.WriteLine("choose fuel Type ");
                        Fuel();
                    }
                    break;

                case 4:
                    {
                        fordon_type = V_Type.boat;
                        Console.WriteLine("enter boat length?");
                        length = int.Parse(Console.ReadLine());
                    }
                    break;

                case 5:
                    {
                        fordon_type = V_Type.motorcycle;
                        Console.WriteLine(" enter cyliner volum?");
                        cylinder_volum = int.Parse(Console.ReadLine());
                    }
                    break;

                default: Console.WriteLine("please choose number between 1 - 5"); break;
            }

        }


        public void Fuel() {
            Console.WriteLine("choose Fuel Type  1- Diesel  2- benzen");
            int choose1 = int.Parse(Console.ReadLine());

            switch (choose1)
            {
                case 1: fuelType = FuelType.Diesel; break;
                case 2: fuelType = FuelType.Gasoline; break;
                default: Console.WriteLine("please choose 1 or 2"); break;
            }
        }


        public IVehcle Creat_vehcle() {
            vehcle_info();

            IVehcle holder = null;
            // Vehcle vehcle = new Vehcle(reg_no,  color, wheels_no);
            switch (fordon_type)
            {

                case V_Type.bus: { Bus obj1 = new Bus(reg_no, color, wheels_no, fuelType); holder = obj1;   break; }
                case V_Type.car: Car obj2 = new Car(reg_no, color, wheels_no, number_of_seats); holder = obj2; break;
                case V_Type.airplane: Airplane obj3 = new Airplane(reg_no, color, wheels_no, number_of_Engines); holder = obj3; break;
                case V_Type.motorcycle: Motorcycle obj4 = new Motorcycle(reg_no, color, wheels_no, cylinder_volum); holder = obj4; break;
                case V_Type.boat: Boat obj5 = new Boat(reg_no, color, wheels_no, length); holder = obj5; break;
                default: Console.WriteLine("please choose number between 1 - 5"); break;

            }
            return holder;
        }
    }
}
