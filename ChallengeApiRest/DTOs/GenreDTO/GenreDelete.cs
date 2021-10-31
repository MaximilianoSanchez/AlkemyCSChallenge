using ChallengeApiRest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.DTOs.GenreDTO
{
    public class GenreDelete
    {

        public int id { get; set; }


        public string name { get; set; }

        public ICollection<Movie> relatedMovie { get; set; }
        public ICollection<Movie> RelatedSeries { get; set; }
    }
}

