using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using CourseWorkLibraryV2;

namespace CourseWorkSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string num;
            string fileNameCreate;
            string fileNameRead;
            string userInput;
            double d;
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
                if (!Int32.TryParse(num, out i)){ }

                //Checks if user inputed 1
                if (i == 1)
                {
                    Category catClass2;

                    Console.Write("Enter JSON Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    DataContractJsonSerializer inputSerializer;
                    inputSerializer = new DataContractJsonSerializer(typeof(Category));

                    catClass2 = (Category)inputSerializer.ReadObject(reader);
                    reader.Close();
                }

                //Checks if user inputed 2
                if (i == 2)
                {
                    Category catClass2;

                    Console.Write("Enter XML Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    DataContractSerializer inputSerializer;
                    inputSerializer = new DataContractSerializer(typeof(Category));

                    catClass2 = (Category)inputSerializer.ReadObject(reader);
                    reader.Close();
                }

                //Checks if user inputed 3
                if (i == 3)
                {
                    //Prompts user for file name 
                    Console.Write("Enter JSON Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts uaser for Name
                    Console.Write("Enter Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in Name
                    catClass.Name = userInput;

                    //Prompts user for Percentage
                    Console.Write("Enter Percentage: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Converts user input into a Double
                    if (!Double.TryParse(userInput, out d)) { }

                    //Stores converted input in Percentage
                    catClass.Percentage = d;

                    //Creates JSON file to be written to 
                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    //Uses the DataContract to write to file
                    DataContractJsonSerializer ser;
                    ser = new DataContractJsonSerializer(typeof(Category));

                    //Writes to file
                    ser.WriteObject(writer, catClass);
                    writer.Close(); //Closes File
                }

                if (i == 4)
                {
                    Console.Write("Enter XML Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    Console.Write("Enter Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    catClass.Name = userInput;

                    Console.Write("Enter Percentage: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    if (!Double.TryParse(userInput, out d)) { }

                    catClass.Percentage = d;

                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    DataContractSerializer ser;
                    ser = new DataContractSerializer(typeof(Category));

                    ser.WriteObject(writer, catClass);
                    writer.Close();
                }

                //TO DO: Display Category Data
                if (i == 5)
                {

                }

                //Checks if user inputed 1
                if (i == 6)
                {
                    Assignment assClass2;

                    Console.Write("Enter JSON Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    DataContractJsonSerializer inputSerializer;
                    inputSerializer = new DataContractJsonSerializer(typeof(Category));

                    assClass2 = (Assignment)inputSerializer.ReadObject(reader);
                    reader.Close();
                }

                if (i == 7)
                {
                    Assignment assClass2;

                    Console.Write("Enter XML Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    DataContractSerializer inputSerializer;
                    inputSerializer = new DataContractSerializer(typeof(Category));

                    assClass2 = (Assignment)inputSerializer.ReadObject(reader);
                    reader.Close();
                }

                //Checks if user inputed 8
                if (i == 8)
                {
                    //Prompts user for file name 
                    Console.Write("Enter JSON Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts user for Name
                    Console.Write("Enter Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in Name
                    assClass.Name = userInput;

                    //Prompts user for Description
                    Console.Write("Enter Description: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User Input in Description
                    assClass.Description = userInput;

                    //Prompts user for CategoryName
                    Console.Write("Enter Category Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in CategoryName
                    assClass.CategoryName = userInput;

                    //Creates JSON file to be written to 
                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    //Uses the DataContract to write to file
                    DataContractJsonSerializer ser;
                    ser = new DataContractJsonSerializer(typeof(Assignment));

                    //Writes to file
                    ser.WriteObject(writer, assClass);
                    writer.Close(); //Closes File
                }

                if (i == 9)
                {
                    //Prompts user for file name 
                    Console.Write("Enter XML Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts user for Name
                    Console.Write("Enter Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in Name
                    assClass.Name = userInput;

                    //Prompts user for Description
                    Console.Write("Enter Description: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User Input in Description
                    assClass.Description = userInput;

                    //Prompts user for CategoryName
                    Console.Write("Enter Category Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in CategoryName
                    assClass.CategoryName = userInput;

                    //Creates XML file to be written to 
                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    //Uses the DataContract to write to file
                    DataContractSerializer ser;
                    ser = new DataContractSerializer(typeof(Category));

                    //Writes to file
                    ser.WriteObject(writer, catClass);
                    writer.Close(); //Closes File
                }

                //TO DO: Display Assignment Data
                if(i == 10)
                {

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
