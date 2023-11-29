using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Transactions;

namespace  siva

{
    class Program
        
    {
        static void Main(string[] args)
        {
            const string a = (" show is data");
            const string d = ("show the data");

            string input = Console.ReadLine();

            switch (input)
            {
                case a:
                    Console.WriteLine("Enter the name");
                    break;
                case d:
                    Console.WriteLine("enter the age");
                    break;
                default:
                    Console.WriteLine("looking the for age");
                    break;

            }

        }
     }

 }
