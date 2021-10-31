using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.DTOs.SeriesDTO
{
    public class SeriesRead
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
    }
}
