using ChallengeApiRest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.Entities
{
    public class Movie
    {

        [Required]
        [Column("Movie Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [Column("Movie Image")]
        public string image { get; set; }
        [Required]
        [Column("Movie Title")]
        public string title { get; set; }
        [Required]
        [Column("Creation Date")]
        public DateTime CreationDate { get; set; }
        [Required]
        [Column("Calification")]
        public int calification { get; set; }

        public ICollection<Character> relatedCharacters { get; set; }






    }
}
