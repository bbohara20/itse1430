/*
 * Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    public class Character : IValidatableObject
    {
        //Data- data to store
        public const int MaximumAttributeValue = 100;
        public const int MinimumAttributeValue = 1;
        public int id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name ?? ""; } set { _name = value; } }
        public string Profession { get { return _profession ?? ""; } set { _profession = value; } }
        public string Race { get { return _race ?? ""; } set { _race = value; } }
        public string Description { get { return _description ?? ""; } set { _description = value; } }
        public int Strength { get { return _strength; } set { _strength= value; } }
        public int Intelligence { get { return _intelligence; } set { _intelligence= value; } }
        public int Agility { get { return _agility; } set { _agility = value; } }
        public int Constitution { get { return _constitution; } set { _constitution = value; } }
        public int Charisma { get { return _charisma; } set { _charisma = value; } }

        private int _id;
        private string _name;
        private string _profession;
        private string _race;
        private string _description;
        private int _strength = 50;
        private int _intelligence = 50;
        private int _agility = 50;
        private int _constitution = 50;
        private int _charisma = 50;

        //public string Validate ()
        //{
        //    // Name is required

        //    if (String.IsNullOrEmpty(Name))
        //        return "Name is required";

        //    if (String.IsNullOrEmpty(Profession))
        //        return "Profession is required";

        //    if (String.IsNullOrEmpty(Race))
        //        return "Race is required";

        //    return null;
       // }
        public override string ToString ()
        {
            return Name;
        }
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            
            //When you are using the iterator syntax then all the return statements must be yield return

            //Name is required
            if (String.IsNullOrEmpty(this.Name))//this.Name
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });
            //Yield returning new validation result with message and string array (collection init syntax) containing a single string with name of Name

            //Run length must be >= 0
            if (String.IsNullOrEmpty(this.Profession))
               // return "Profession is required";
            yield return new ValidationResult("Profession is required", new[] { nameof(Profession) });

            
            if (String.IsNullOrEmpty(this.Race))


                yield return new ValidationResult("Race is required", new[] { nameof(Race) });

            //return null;
        }

    }

}












