/* 
 * Bam bohara
 * ITSE 1430 
 * Movie Library consle Application 
 */
using System;


namespace MovieLibrary
{
    internal class Program
    {
        private static void Main ( string[] args )
        {
            //FunWithTypes()    
            // FunWithvariables();
            DisplayMenu();
            string title = "";
            string discription = "";
            string rating = "";
            int duration;
          }

         static char DisplayMenu ()
         {
            // do s while (E);
            do
            {

                Console.WriteLine("Movie Library");
                Console.WriteLine("------------------");

                Console.WriteLine("Q)uit");
                // Get the input from user
                string input = Console.ReadLine();
                if (input == "Q")
                    return 'Q';

                Console.WriteLine("Invalid option");
            } while (true);
            

           }

           }

        }
     