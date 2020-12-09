
/*
 * Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator
{
    public interface ICharacterRoster
    {
        Character Add ( Character character );

        void Delete ( int id );
        Character Get ( int id );
        IEnumerable<Character> GetAll ();
        void Update ( int id, Character character );
    }
}
