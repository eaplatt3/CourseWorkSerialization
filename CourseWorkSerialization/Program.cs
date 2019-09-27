using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using CourseWorkLibraryV2;

/////////////////////////////////////////////////////////////////////////
// File: Program.cs                                                    //
//                                                                     //
// Purpose: Contains the Menu and File Creation & Reading              //
//                                                                     //
// Written By: Earl Platt III                                          //
//                                                                     //
// Compiler: Visual Studio 2019                                        //
//                                                                     //
/////////////////////////////////////////////////////////////////////////

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

            #region Do-while Loop
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
                    //Create Second Instantiation
                    Category catClass2;

                    //Prompt User for filename
                    Console.Write("Enter JSON Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    //Searches and Opens file
                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    //Pulls Data from file
                    DataContractJsonSerializer inputSerializer;
                    inputSerializer = new DataContractJsonSerializer(typeof(Category));

                    //Pulls Data from file and inputs it into class
                    catClass2 = (Category)inputSerializer.ReadObject(reader);
                    reader.Close(); //Closes File
                }

                //Checks if user inputed 2
                if (i == 2)
                {
                    //Create Second Instantiation
                    Category catClass2;

                    //Prompt User for filename
                    Console.Write("Enter XML Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    //Searches and Opens file
                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    //Pulls Data from file
                    DataContractSerializer inputSerializer;
                    inputSerializer = new DataContractSerializer(typeof(Category));

                    //Pulls Data from file and inputs it into class
                    catClass2 = (Category)inputSerializer.ReadObject(reader);
                    reader.Close();
                }

                //Checks if user inputed 3
                if (i == 3)
                {
                    //Prompts user for filename 
                    Console.Write("Enter JSON Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts user for Name
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

                //Checks if user inputed 4
                if (i == 4)
                {
                    //Prompts user for filename 
                    Console.Write("Enter XML Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts user for Name
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

                    //Creates XML file to be written to 
                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    //Uses the DataContract to write to file
                    DataContractSerializer ser;
                    ser = new DataContractSerializer(typeof(Category));

                    //Writes to file
                    ser.WriteObject(writer, catClass);
                    writer.Close(); //Closes File
                }

                //TO DO: Display Category Data
                if (i == 5)
                {

                }

                //Checks if user inputed 6
                if (i == 6)
                {
                    //Create Second Instantiation
                    Assignment assClass2;

                    //Prompts user for filename 
                    Console.Write("Enter JSON Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    //Searches and Opens file
                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    //Pulls Data from file
                    DataContractJsonSerializer inputSerializer;
                    inputSerializer = new DataContractJsonSerializer(typeof(Category));

                    //Pulls Data from file and inputs it into class
                    assClass2 = (Assignment)inputSerializer.ReadObject(reader);
                    reader.Close(); //Closes File
                }

                if (i == 7)
                {
                    //Create Second Instantiation
                    Assignment assClass2;

                    //Prompts user for filename 
                    Console.Write("Enter XML Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    //Searches and Opens file
                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    //Pulls Data from file
                    DataContractSerializer inputSerializer;
                    inputSerializer = new DataContractSerializer(typeof(Category));

                    //Pulls Data from file and inputs it into class
                    assClass2 = (Assignment)inputSerializer.ReadObject(reader);
                    reader.Close(); //Closes File
                }

                //Checks if user inputed 8
                if (i == 8)
                {
                    //Prompts user for filename 
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
                    //Prompts user for filename 
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
                    ser = new DataContractSerializer(typeof(Assignment));

                    //Writes to file
                    ser.WriteObject(writer, assClass);
                    writer.Close(); //Closes File
                }

                //TO DO: Display Assignment Data
                if(i == 10)
                {

                }

                //Checks if user inputed 11
                if (i == 11)
                {
                    //Create Second Instantiation
                    Submission subClass2;

                    //Prompts user for filename 
                    Console.Write("Enter JSON Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    //Searches and Opens file
                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    //Pulls Data from file
                    DataContractJsonSerializer inputSerializer;
                    inputSerializer = new DataContractJsonSerializer(typeof(Submission));

                    //Pulls Data from file and inputs it into class
                    subClass2 = (Submission)inputSerializer.ReadObject(reader);
                    reader.Close(); //Closes File
                }

                //Checks if user inputed 12
                if (i == 12)
                {
                    //Create Second Instantiation
                    Submission subClass2;

                    //Prompts user for filename 
                    Console.Write("Enter XML Filename: ");
                    fileNameRead = Console.ReadLine();
                    Console.WriteLine("");

                    //Searches and Opens file
                    FileStream reader = new FileStream(fileNameRead, FileMode.Open, FileAccess.Read);

                    //Pulls Data from file
                    DataContractSerializer inputSerializer;
                    inputSerializer = new DataContractSerializer(typeof(Submission));

                    //Pulls Data from file and inputs it into class
                    subClass2 = (Submission)inputSerializer.ReadObject(reader);
                    reader.Close(); //Closes File
                }

                //Checks if user inputed 13
                if (i == 13)
                {
                    //Prompts user for filename 
                    Console.Write("Enter JSON Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts user for categoryName
                    Console.Write("Enter Category Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in categoryName
                    subClass.CategoryName = userInput;

                    //Prompts user for assignmentName
                    Console.Write("Enter Assignment Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User Input in assignmentName
                    subClass.AssignmentName = userInput;

                    //Prompts user for Grade
                    Console.Write("Enter Grade: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Converts user input into a Double
                    if (!Double.TryParse(userInput, out d)) { }

                    //Stores converted input in Grade
                    subClass.Grade = d;

                    //Creates JSON file to be written to 
                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    //Uses the DataContract to write to file
                    DataContractJsonSerializer ser;
                    ser = new DataContractJsonSerializer(typeof(Submission));

                    //Writes to file
                    ser.WriteObject(writer, subClass);
                    writer.Close(); //Closes File
                }

                //Checks if user inputed 14
                if (i == 14)
                {
                    //Prompts user for filename 
                    Console.Write("Enter XML Filename: ");
                    fileNameCreate = Console.ReadLine();
                    Console.WriteLine("");

                    //Prompts user for categoryName
                    Console.Write("Enter Category Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User input in categoryName
                    subClass.CategoryName = userInput;

                    //Prompts user for assignmentName
                    Console.Write("Enter Assignment Name: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Stores User Input in assignmentName
                    subClass.AssignmentName = userInput;

                    //Prompts user for Grade
                    Console.Write("Enter Grade: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine("");

                    //Converts user input into a Double
                    if (!Double.TryParse(userInput, out d)) { }

                    //Stores converted input in Grade
                    subClass.Grade = d;

                    //Creates XML file to be written to 
                    FileStream writer = new FileStream(fileNameCreate, FileMode.Create, FileAccess.Write);

                    //Uses the DataContract to write to file
                    DataContractSerializer ser;
                    ser = new DataContractSerializer(typeof(Submission));

                    //Writes to file
                    ser.WriteObject(writer, subClass);
                    writer.Close(); //Closes File
                }

                //TO DO: Display Submission Data
                if (i == 15)
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
