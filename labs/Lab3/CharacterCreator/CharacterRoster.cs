/*
 * Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;

namespace CharacterCreator
{
    public abstract class CharacterRoster : ICharacterRoster
    {
        private List<Character> _characters = new List<Character>();
        private static int lastId = 0;

        public Character Add ( Character character )
        {

            if (character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }


            var existing = GetByName(character.Name);
            if (existing != null)
                throw new InvalidOperationException("Character name must be unique");
            try
            {
                return AddCharacter(character);
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
            //Find highest ID
            var characters = _characters;
            var items = new List<Character>(characters);

            //Set a unique ID
            character.id = ++lastId;
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

                if (item.id == id)

                    _characters.RemoveAt(i);
                i++;

            };
        }

        public Character get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            var items = new List<Character>(_characters);
            foreach (var item in items)
            {
                int i = 0;

                if (item.id == id)

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
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            var existing = GetByName(character.Name);
            if (existing != null && existing.id != id)
                throw new InvalidOperationException("Character must be unique");
            //Remove old character
            var items = new List<Character>(_characters);
            foreach (var item in items)
            {
                //Use item not character
                if (item.id == id)
                {
                    //Must use item here, not character
                    items.Remove(item);
                    break;
                };
            };

            //Add new character
            character.id = id;
            items.Add(character);
            SaveCharacters(items);

        }
        protected void UpdateCore ( int id, Character character )
        {
            //Remove old character
            var items = new List<Character>(_characters);
            foreach (var item in items)
            {
                //Use item not character
                if (item.id == id)
                {
                    //Must use item here, not character
                    items.Remove(item);
                    break;
                };
            };

            //Add new character
            character.id = id;
            items.Add(character);

            SaveCharacters(items);
        }

    }
}


