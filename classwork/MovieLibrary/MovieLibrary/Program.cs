/* 
 * Bam Bohara
 * Date 08/31/2020
 * class work 
 */
using System;
using System.Reflection.Metadata;

namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            FunWithTypes();
            
        }

        static void FunWithTypes ()
        {
            // Body

            // Primitive - Types
            // variable declaration
            int hours = 10;
            int code = 0xFF;
            int ratio = hours * 40;
            // floating point types - real numbers IEEE
            // float = 4 bytes, +=E38; 7 to 9 precision 1234566789
            
            double payRate = 123.456789;
            payRate = 123E12;
            decimal price = 456.746M;
            // boolean
            bool ispassing = true;
            // texTual;
            // char 2 byte 
            char LetterA = 'A';
            char digito = '1';
            char hex = '\x0A';

            string name = "Bob";
            string empty = "";
        }
    }
}
