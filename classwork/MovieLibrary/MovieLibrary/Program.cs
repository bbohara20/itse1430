using System;
namespace Movielibrary
{
    class program
    {
        static void Main( string[]args)
        {
            FunWithTypes();
        }

        
        // function definition = declaration + implementation
     static void FunWithTypes()
        {
            // body
            //primitive type implicity known by the language
            int hours = 10;
            int code = 0xFF;
            int ratio = hours * 40;
            // floating point types - real numbers
            double payRate = 123.456789;
            payRate = 123E12;
            decimal price = 456.746M;  // Precise = currency using decimal and M means Money

            // boolean \
            // bool = 1 byte,true or false
            bool isPassing = true;

            // Textual
            //char = 2 byte

            char letterA = 'A';
            char digito = '1'; // '1' is not == 1
            char hex = '\x0A'; // char return
            string name = "Bob";
            string empty = "";
            }

    }

}