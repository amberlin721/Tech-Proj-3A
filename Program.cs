// Author: Xiao Lin
// Date: 09/22/2020
// Description: This C# application code demostrates the use of methods after getting input from a user. 

using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Tech_Proj_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter their name to display the messae
            Console.WriteLine("Please enter your name to display the greeting message.");


            // use the try catch block to validate user input.
            // if the user provides bad input, the catch block will handle the error and a messahe will be displayed.
            try
            {
                string name; //variable for storing string value
                name = Console.ReadLine(); //accepting and holding value in name variable


                Console.WriteLine("Hello {0}", name + " -Go Bucs"); // display output
                Console.WriteLine("Please press any key to exit the program...");
                Console.ReadKey(true);
            } // end of try


            catch
            {
                Console.WriteLine("Please enter your name to display the greeting message.");
                Console.WriteLine("Please press any key to exit the program...");
                Console.ReadKey(true);
            } // end of catch
        } //end of main

    } //end of class
} //end of namespace
