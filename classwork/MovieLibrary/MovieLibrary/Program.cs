using System;
using System.Reflection.PortableExecutable;

namespace MovieLibrary
{
    class Program
    {
        static void Main ( string[] args )
        {
            FunWithTypes();
         }
        // function defination = declaration + implementation
        static void FunWithTypes()
        {
            // variable declaration
            int hours = 10;
            int code = 0xFF;
            int ratio = hours * 40;

            // floating point  Types
            double payRate = 123.456789;
            payRate = 123E12;
            decimal price = 456.746M; // M = money/price

            // boolean
            // bool = 1 byte, true or false(0)
            bool isPassing = true;

            // texttual
            char letterA = 'A';
            char digito = '1'; // is not ==1
            char hex = '\x0A'; //Character return
            string name = "Bob";
            string empty = "";
              
        }


    }

}