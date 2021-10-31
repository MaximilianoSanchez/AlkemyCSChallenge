using ChallengeApiRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.Repositories
{
    public  interface IRepository <T1, T2> where T1: class
    {
        bool SaveChanges();
        IEnumerable<T1> GetCharacter();
        T1 GetCharacterById(int id);
        void CreateCharacter(T1 newCharacter);
        void UpdateCharacter(T1 updateCharacter);
        void DeleteCharacter(T1 deleteCharacter);
    }
}
