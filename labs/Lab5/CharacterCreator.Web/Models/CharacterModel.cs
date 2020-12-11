/*
 * Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CharacterCreator.Web.Models
{
    public class CharacterModel : IValidatableObject
    {
        public CharacterModel ()
        { }

        public CharacterModel ( Character character )
        {
            //Transform from business object to model
            Id = character.Id;
            Name = character.Name;
            Profession = character.Profession;
            Race = character.Race;
            Strength = character.Strength;
            Intelligence = character.Intelligence;
            Agility = character.Agility;
            Constitution = character.Constitution;
            Charisma = character.Charisma;
            Description = character.Description;
        }
        public Character ToCharacter ()
        {
            return new Character() {
                Id = Id,
                Name = Name,
                Profession = Profession,
                Race = Race,
                Strength = Strength,
                Intelligence = Intelligence,
                Agility = Agility,
                Constitution = Constitution,
                Charisma = Charisma,
                Description = Description,
            };
        }
        //Data- data to store
        public const int MaximumAttributeValue = 100;
        public const int MinimumAttributeValue = 1;
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Profession { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Race { get; set; }

        [Range(1, 100, ErrorMessage = "Strength must be between 1 to 100.")]
        public int Strength { get; set; }

        [Range(1, 100, ErrorMessage = "Intelligence must be between 1 to 100.")]
        public int Intelligence { get; set; }

        [Range(1, 100, ErrorMessage = "Agility must be between 1 to 100.")]
        public int Agility { get; set; }

        [Range(1, 100, ErrorMessage = "Constitution must be between 1 to 100.")]
        public int Constitution { get; set; }

        [Range(1, 100, ErrorMessage = "Charisma must be between 1 to 100.")]
        public int Charisma { get; set; }

        public string Description { get; set; }
        public override string ToString ()
        {
            return Name;
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (!String.Equals(Profession, "Fighter") && !String.Equals(Profession, "Hunter") && !String.Equals(Profession, "Priest") && !String.Equals(Profession, "Rogue") && !String.Equals(Profession, "Wizard"))
                yield return new ValidationResult("Profession must be Fighter, Hunter, Priest, Rogue, Wizard", new[] { nameof(Profession) });

            if (!String.Equals(Race, "Dwarf") && !String.Equals(Race, "Elf") && !String.Equals(Race, "Gnome") && !String.Equals(Race, "Half Elf") && !String.Equals(Race, "Human"))
                yield return new ValidationResult("Race  must be Dwarf, Elf, Gnome , Half Elf, Human", new[] { nameof(Race) });
        }

    }

}










