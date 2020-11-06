﻿/*
 * Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
namespace CharacterCreator
{
    public class Character
    {
        //Data- data to store
        public const int MaximumAttributeValue = 100;
        public const int MinimumAttributeValue = 1;
        public string Name { get { return _name ?? ""; } set { _name = value; } }
        public string Profession { get { return _profession ?? ""; } set { _profession = value; } }
        public string Race { get { return _race ?? ""; } set { _race = value; } }
        public string Description { get { return _description ?? ""; } set { _description = value; } }
        public int Strength { get { return _strength; } set { _strength= value; } }
        public int Intelligence { get { return _intelligence; } set { _intelligence= value; } }
        public int Agility { get { return _agility; } set { _agility = value; } }
        public int Constitution { get { return _constitution; } set { _constitution = value; } }
        public int Charisma { get { return _charisma; } set { _charisma = value; } }

        private string _name;
        private string _profession;
        private string _race;
        private string _description;
        private int _strength = 50;
        private int _intelligence = 50;
        private int _agility = 50;
        private int _constitution = 50;
        private int _charisma = 50;

        public string Validate ()
        {
            // Name is required

            if (String.IsNullOrEmpty(Name))
                return "Name is required";

            if (String.IsNullOrEmpty(Profession))
                return "Profession is required";

            if (String.IsNullOrEmpty(Race))
                return "Race is required";

            return null;
        }
        public override string ToString ()
        {
            return Name;
        }
       

    }
    
}


          









