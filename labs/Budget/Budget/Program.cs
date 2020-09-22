/*Bam Bohara
* Date: 09/02/2020
  * ITSE 1430
  * Lab 1using
  */

using System;


namespace Budget
{


    class Program
    {

        static void Main ( string[] args )
        {
            while (true)


            {

            switch (DisplayMenu())
                  {
                    case 'Q': QUIT_PROGRAM(); break;
                    case 'A': AddMenu(); break;
                };
            };
        }


        static string accountName = "";
        static string accountNumber = "";
        static decimal startingBalance;

        static bool ReadBoolean ()
        {
            do
            {
                //Read as string
                string value = Console.ReadLine();

                switch (value.ToLower())
                {
                    case "X": Console.WriteLine("Wrong value"); break;

                    case "Y":
                    case "y": return true;
                    // case "N": 
                    case "n": return false;
                    //case "A":
                    case "a":
                    {
                        //Use block statement for more than 1 statement
                        Console.WriteLine("Wrong value");
                        Console.WriteLine("Wrong value again");
                        break;
                    };
                    default: break; //if nothing else
                };

                DisplayError("Invalid option");
            } while (true);
        }

        static void AddMenu ()
        {
            // get account name
            Console.WriteLine("Account Name: ");
            accountName = Console.ReadLine();
            //get account number
            Console.WriteLine("Account Number : ");
            accountNumber = ReadInt32(1).ToString();
            //get starting balance
            Console.WriteLine("Starting Balance:");
            startingBalance =  decimalValue();
        }

        static char DisplayMenu ()
        {
            // 1+ iteration, post test
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Account information");
                Console.WriteLine("---------------------");
                Console.WriteLine("Account Name: ");
                Console.WriteLine(accountName);
                Console.WriteLine("Account Number: ");
                Console.WriteLine(accountNumber);
                Console.WriteLine("startingBalance:");
                Console.WriteLine(startingBalance.ToString("C"));

                Console.WriteLine("A)dd accountInfo");
                Console.WriteLine("Q)uit");
                //Get input from user
                string value = Console.ReadLine();

                if (value  == "Q")   // 2 equal signs => equality 
                                     //if (value == "Q")   // 2 equal signs => equality 
                    if (String.Compare(value, "Q", true) == 0)
                        return 'Q';
                if (value  == "A")
                    return 'A';
                else if (String.Compare(value, "A", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return 'A';
                //else if (value == "V")
                else if (String.Compare(value, "V", true) == 0)
                    return 'V';

                DisplayError("Invalid option");

            } while (true);
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

        static void QUIT_PROGRAM ()
        {
            Console.WriteLine("Is quit program( Y/ N)? ");

            //title = ReadString(true);
            string value = ReadString(true);
            if (value  == "Y" || value == "y")
            {

                System.Environment.Exit(-1);
            } else
            {
                DisplayMenu();
                return;
            }



        }
    }
}




