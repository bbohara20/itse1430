/*Bam Bohara
 *Date: 09/02/2020
  * ITSE 1430
  * Lab 1
  */
using System;

namespace Budget
{


    class Program
    {

        static void Main ( string[] args )
        {
            accountInfo();
        }
        static string accountName = "";
        static string accountNumber = "";
        static string StartingBalance = "";
        static void accountInfo ()
        {
        Console.WriteLine("Enter your account Name: ");
        accountName = ReadString(true);
        Console.WriteLine("Enter your Account number: ");
        accountNumber = ReadInt32(10).ToString();
        Console.WriteLine("Enter your Starting Balance: ");
        accountNumber = decimalValue(1.0M).ToString();
        }
    static decimal decimalValue ()
        {
            return decimalValue(Decimal.MinValue);
        }
    static decimal decimalValue ( decimal minimumValue )
    {
        do
        {
            string value = Console.ReadLine();

            //if (Int32.TryParse(value, out int result) && result >= minimumValue)
            if (Decimal.TryParse(value, out var result) && result >= minimumValue)
                return result;
            
            if (minimumValue != Decimal.MinValue)   //Int32.MaxValue
                DisplayError("Value must be at least " + minimumValue);  //String concatenation
            else
                DisplayError("Must be integral value");
        }
        while (true);
    }
    static int ReadInt32 ()
    {
        return ReadInt32(Int32.MinValue);
    }
    static int ReadInt32 ( int minimumValue )
    {
        do
        {
        string value = Console.ReadLine();
        //if (Int32.TryParse(value, out int result) && result >= minimumValue)
        if (Int32.TryParse(value, out var result) && result >= minimumValue)
            return result;


        if (minimumValue != Int32.MinValue)   //Int32.MaxValue
            DisplayError("Value must be at least " + minimumValue);  //String concatenation
        else
            DisplayError("Must be integral value");
        } while (true);
    }
    private static void DisplayError ( string message )
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    static string ReadString ( bool required )
    {
        do
        {
            string value = Console.ReadLine();
            //If not required or not empty return
            if (!required || value != "")
                return value;
            DisplayError("Value is required");

        } while (true);

       }
    }
 }


