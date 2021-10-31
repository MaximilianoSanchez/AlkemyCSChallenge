using ChallengeApiRest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.DTOs.CharacterDTO
{
    public class CharacterUpdateDTO
    {
        public int id { get; set; }

        public string image { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public double weight { get; set; }

        public string story { get; set; }


        public ICollection<Movie> RelatedMovie { get; set; }
        public ICollection<Series> RelatedSeries { get; set; }
    }
}
