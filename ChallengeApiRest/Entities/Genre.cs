using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.Entities
{
    public class Genre
    {

        [Required]
        [Column("Genre Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [Column("Genre Name")]
        public string image { get; set; }
        [Required]
        [Column("Genre Name")]

        public string name { get; set; }

        public ICollection<Movie> relatedMovie { get; set; }
        public ICollection<Movie> RelatedSeries { get; set; }

    }
}
