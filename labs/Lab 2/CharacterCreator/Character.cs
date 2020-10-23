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
            
               return null;
        
    
           }
         }

    }




 

