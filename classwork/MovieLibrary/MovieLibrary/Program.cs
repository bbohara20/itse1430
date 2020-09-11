/*
 * Bam Bohara
 * ITSE1430
 * Movie library consloe Application
 */
using System;

namespace MovieLbirary
{

    class program
    {
        static void Main ( string[] args )
        {
            // while loop
            // while = while(E) s;
            while (true)
            {
                //scope - Lifetime of a variable: starts at declaration and continues until end of current scope
                char choice = DisplayMenu();
                if (choice == 'Q')
                    return;
            };
            string title = "";
            string description = "";
            string rating = "";
            int duration; ;
        }

        static char DisplayMenu ()
        {
            // do s while(E)
            do
            {
                Console.WriteLine("Movie Library");
                Console.WriteLine("----------------");
                Console.WriteLine("Q)uit");
                // Get input from user
                string value = Console.ReadLine();
                // if(E) s;
                if (value == "Q")
                    return 'Q';
                DisplayError();
            } while (true);



        }

        private static void DisplayError ()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("invalid option");
            Console.ResetColor();

        }
    }

}






