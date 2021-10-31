using ChallengeApiRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.DTOs
{
    public class MovieCreate
    {
        public int id { get; set; }

        public string image { get; set; }
        public string title { get; set; }

        public DateTime CreationDate { get; set; }

        public int calification { get; set; }

        public ICollection<Character> relatedCharacters { get; set; }

    }
}
