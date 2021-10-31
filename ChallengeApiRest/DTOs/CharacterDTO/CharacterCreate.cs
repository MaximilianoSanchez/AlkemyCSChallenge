using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ChallengeApiRest.Entities;

namespace ChallengeApiRest.Models
{
    public class CharacterCreate
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
