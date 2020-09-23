using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Garage;


namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {

            //Arrange
            GarageClass<IVehcle> garage = new GarageClass<IVehcle>();
            string reg_no = Console.ReadLine();
            bool reg_No_Validation = true;


            //Act

         

            foreach (var vehcle in garage)
            {
                if (vehcle is null)
                {

                    reg_No_Validation = false;
                    continue;
                }

                else if (vehcle.RegisterNumber.Equals(reg_no, System.StringComparison.InvariantCultureIgnoreCase))
                //  else if (vehcle.RegisterNumber == reg_no)

                {
                    reg_No_Validation = true;
                    Console.WriteLine($" the reg number that you choosed is existed in garage  ");
                    break;
                }

                else
                { reg_No_Validation = false; }
            }

            //Assert

            Assert.IsTrue( reg_No_Validation);
        }

        public void TestMethod2() {

            //Arrange
            GarageClass<IVehcle> garage = new GarageClass<IVehcle>();
            string reg_no = Console.ReadLine();
            bool reg_No_Validation = true;


            //Act



            foreach (var vehcle in garage)
            {
                if (vehcle is null)
                {

                    reg_No_Validation = false;
                    continue;
                }

                else if (vehcle.RegisterNumber.Equals(reg_no, System.StringComparison.InvariantCultureIgnoreCase))
                //  else if (vehcle.RegisterNumber == reg_no)

                {
                    reg_No_Validation = true;
                    Console.WriteLine($" the reg number that you choosed is existed in garage  ");
                    break;
                }

                else
                { reg_No_Validation = false; }
            }

            //Assert

            Assert.IsFalse(reg_No_Validation);
        }
    }
    
}
