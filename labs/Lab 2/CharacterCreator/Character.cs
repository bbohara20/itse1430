/*
 * ITSE 1430
 * Bam Bohara
 * Lab 2
 */
using System;
//using System.Collections.Generic;
//using System.Text;

namespace CharacterCreator
{
    public class Character
    {
      //Data- data to store
        public string Name = "";
        public string Profession = "";
        public string Race = "";
        public int Strength = 50;
        public int Intelligence = 50;
        public int Agility = 50;
        public int Constitution = 50;
        public int Charisma = 50;
        public string description = "";
        // Functionality
        /// <summary>Validate the character instance. </summary>
        /// <returns>the error message if any. </returns>
       public string Validate ()
        {
            
            // Name is required
            if (String.IsNullOrEmpty(Name))
                 return "Name is required";
            // Strength must be greater than 1
           // if (Strength < 1 )
               // return "Strength must be at least 1";

           // if (Strength < 100)
            //return "Strength must be less than 100";
            //if (Intelligence >= 1)
               // return " Intelligence must be greater than 1";
             //if (Intelligence < 100)
              //  return "Intelligence must be at least 100";
           // if (Agility >= 1)
               // return " Agility must be greater than 0";

            
           // if (Agility < 100)
           //    return "Agility must be at least 100";

           // if (Constitution  > 0 )
           //     return " Constitution  must be greater than 0";

           //if (Constitution  < 100)
           //     return "Constitution must be at least 100";
           // if (Charisma  > 0)
           //     return " Charisma  must be greater than 0";

           //  if (Charisma  <= 100)
              //  return " must be at least 100";

               return null;
        
    
           }
         }

    }




 

