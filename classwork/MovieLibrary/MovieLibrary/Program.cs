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
                    else if (choice == 'A')
                        AddMenu();
                        };

                string title = "";
                string description = "";
                string rating = "";
                int duration; ;
                }


            static void AddMenu ()
            {
                // Get title
                Console.WriteLine(" Movie title: ");
                string title = Console.ReadLine();
                // Get description 
                Console.WriteLine("Description  : ");
                string description = Console.ReadLine();
                // Get rating
                Console.WriteLine("Rating: ");
                string rating = Console.ReadLine();
                // Get duration
                Console.WriteLine("Duration : ");
                string duration = Console.ReadLine();
                // Get is classic
                Console.WriteLine("IS classic (Y/N)? " );
                string isClasssic = Console.ReadLine();

                }

            static char DisplayMenu ()
            {
                // do s while(E)
                do
                {
                    Console.WriteLine("Movie Library");
                    Console.WriteLine("----------------");
                    Console.WriteLine("A)dd Movie");
                    Console.WriteLine("Q)uit");
                

                    // Get input from user
                    string value = Console.ReadLine();
                    // if(E) s;
                    //if(E) s else s;
                    if (value == "Q")
                        return 'Q';
                    else if (value == "A")
                        return 'A';
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






