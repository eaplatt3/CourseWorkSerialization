using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkLibraryV2;

namespace CourseWorkSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string num;
            int i;

            #region Class Instatiation
            //Class Instantiation
            Category catClass = new Category();
            Assignment assClass = new Assignment();
            Submission subClass = new Submission();
            #endregion

            #region Do while Loop
            //Loop to loop menu
            do
            {
                Console.WriteLine("CourseWork Menu");
                Console.WriteLine("---------------");
                Console.WriteLine("1 - Read Category from JSON file");
                Console.WriteLine("2 - Read Category from XML file");
                Console.WriteLine("3 - Write Category to JSON file");
                Console.WriteLine("4 - Write Category to XML file");
                Console.WriteLine("5 - Display Category data on screen");
                Console.WriteLine("6 - Read Assignment from JSON file");
                Console.WriteLine("7 - Read Assignment from XML file");
                Console.WriteLine("8 - Write Assignment to JSON file");
                Console.WriteLine("9 - Write Assignment to XML file");
                Console.WriteLine("10 - Display Assignment data on screen");
                Console.WriteLine("11 - Read Submission from JSON file");
                Console.WriteLine("12 - Read Submission from XML file");
                Console.WriteLine("13 - Write Submission to JSON file");
                Console.WriteLine("14 - Write Submission to XML file");
                Console.WriteLine("15 - Display Submission data on screen");
                Console.WriteLine("16 - Exit");
                Console.Write("Enter Choice: ");
                num = Console.ReadLine();
                Console.WriteLine("");

                //Parse string to int 
                if (!Int32.TryParse(num, out i))
                {

                }

                //Checks if user inputed 1
                if (i == 1)
                {
                    CourseWorkUnitTesting test = new CourseWorkUnitTesting();

                    Console.WriteLine("**********************");
                    Console.WriteLine("Unit Testing: Category");
                    Console.WriteLine("**********************");
                    test.UnitTestCategory();
                    Console.WriteLine("");
                }

                //Checks if user inputed 2
                if (i == 2)
                {
                    CourseWorkUnitTesting test = new CourseWorkUnitTesting();

                    Console.WriteLine("**********************");
                    Console.WriteLine("Unit Testing: Assigment");
                    Console.WriteLine("**********************");
                    test.UnitTestAssignment();
                    Console.WriteLine("");
                }

                //Checks for vaild user input
                if (i < 1 || i > 16)
                {
                    Console.WriteLine("Invaild Input");
                    Console.WriteLine("Enter 1 to 16");
                    Console.WriteLine("");
                }

            } while (i != 16); //Loop will not exit until user inputs 16 
            #endregion

            //Checks if user inputed 16
            if (i == 16)
            {
                //Terminates Application
                System.Environment.Exit(1);
            }
        }
    }
}
