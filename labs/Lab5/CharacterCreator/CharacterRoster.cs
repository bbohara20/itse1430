/*
 * Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;

using System.Linq;

namespace CharacterCreator
{
    public abstract class CharacterRoster : ICharacterRoster
    {
        private List<Character> _characters = new List<Character>();
        private static int lastId = 0;

        public Character Add ( Character character )
        {
            var item = character;
            if ( item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            var validationResults = new ObjectValidator().TryValidateFullobject(item);
            if (validationResults.Count() > 0)
            {
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };
                // Show error message
                throw new Exception(builder.ToString());

                // return null;
            };


            var existing = GetByName(item.Name);
            if (existing != null)
                throw new InvalidOperationException("Character name must be unique");
            try
            {
                return AddCharacter(item);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Add Failed", e);
            };
        }
        protected virtual Character GetByName ( string name )
        {
            foreach (var character in _characters)
            {
                if (String.Compare(character.Name, name, true) == 0)
                    return character;
            };

            return null;
        }
        public void Delete ( int id )
        {
            // Validate Id > 0
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            //Generalize errors            
            try
            {
                DeleteCharacter(id);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Delete Failed", e);
            };
        }
        Character AddCharacter ( Character character )
        {
            var items = new List<Character>(_characters);


            //Set a unique ID
            character.Id = ++lastId;
            items.Add(character);

            // Save character
            SaveCharacters(items);
            return character;
        }
        public void SaveCharacters ( List<Character> items )
        {
            _characters.Clear();
            _characters = items;
        }
        public void DeleteCharacter ( int id )
        {


            var items = new List<Character>(_characters);


            foreach (var item in items)
            {
                int i = 0;

                if (item.Id == id)

                    _characters.RemoveAt(i);
                i++;

            };
        }

        public Character Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            var items = new List<Character>(_characters);
            foreach (var item in items)
            {
                int i = 0;

                if (item.Id == id)

                    return _characters[i];
                i++;

            };
            return null;
        }
        public IEnumerable<Character> GetAll ()
        {
            try
            {
                return _characters;
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("GetAll Failed", e);
            };
        }
        public void Update ( int id, Character character )
        {
            //Validation
            var selection = character;
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            var validationResults = new ObjectValidator().TryValidateFullobject(selection);
            if (validationResults.Count() > 0)
            {
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };
                // Show error message
                throw new Exception(builder.ToString());

                // return null;
            };


            var existing = GetByName(selection.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Character must be unique");
            //Remove old character
            var items = new List<Character>(_characters);
            foreach (var item in items)
            {
                //Use item not character
                if (item.Id == id)
                {
                    //Must use item here, not character
                    items.Remove(item);
                    break;
                };
            };

            //Add new character
            selection.Id = id;
            items.Add(selection);
            SaveCharacters(items);

        }


    }
}


