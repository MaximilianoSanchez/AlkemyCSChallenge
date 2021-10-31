using ChallengeApiRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeApiRest.Context;
using ChallengeApiRest.Entities;
namespace ChallengeApiRest.Repositories

{
    public class CharacterRepository : IRepository<Character, int>
    {
        private readonly DisneyDBContext context;

        public CharacterRepository(DisneyDBContext context) => this.context = context;

        public void CreateCharacter(Character newCharacter)
        {
            if (newCharacter == null)
            {
                throw new ArgumentNullException(nameof(newCharacter));
            }

            context.Character.Add(newCharacter);
            context.SaveChanges();
        }

        public void DeleteCharacter(Character deleteCharacter)
        {


            if (deleteCharacter == null)
            {
                throw new ArgumentNullException(nameof(deleteCharacter));
            }
            context.Character.Remove(deleteCharacter);

        }

        public IEnumerable<Character> GetCharacter()
        {
            return context.Characters;
        }

        public Character GetCharacterById(int id)
        {
            return context.Characters.FirstOrDefault(c => c.id == id);
        }

        public bool SaveChanges()
        {
            return (context.SaveChanges() >= 0);
        }

        public void UpdateCharacter(Character updateCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
