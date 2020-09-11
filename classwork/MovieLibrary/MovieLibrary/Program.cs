/*Bam Bohara 
 * ITSE 1430
 * Movie Library console Aplication
 */
using System;
namespace MovieLibrary
{
    class Program
    {
        static void Main ( string[] args )
        {
            //FunWithTypes();
            //FunWithvariables();

            // while loop (boolean (E) s;
            while (true)
            {
                //Scope - lifetime of a variables: starts at declaration and continues end of current scope
                char choice = DisplayMenu();
                if (choice == 'Q')
                    return;
            };
            string title = "";
            string description = "";
            string rating = "";
            int duration;

        }
        static char DisplayMenu ()
        {
            // do single statement while (E)
            // block statement = {signle statement + }
            // display menu
            do
            {
                Console.WriteLine("Movie Library");
                Console.WriteLine("---------------------");
                Console.WriteLine("Q(uit");

                //Get input from user
                string value = Console.ReadLine();
                // if (E) s;
                if (value =="Q")
                    return 'Q';
                DisplayError();
            } while (true);

        }

        private static void DisplayError ()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Invalid option");

            Console.ResetColor();
        }
    }
}