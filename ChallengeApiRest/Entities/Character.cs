using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ChallengeApiRest.Entities;

namespace ChallengeApiRest.Models
{
    public class Character
    {
        [Required]
        [Column("Character Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [Column("Character Image")]
        public string image { get; set; }
        [Required]
        [Column("Character Name")]
        public string name { get; set; }
        [Required]
        [Column("Character Age")]
        public int age { get; set; }
        [Required]
        [Column("Character Weight")]
        public double weight { get; set; }
        [Required]
        [Column("Character Story")]
        public string story { get; set; }


        public ICollection<Movie> RelatedMovie { get; set; }
        public ICollection<Series> RelatedSeries { get; set; }




    }
}
