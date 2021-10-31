using ChallengeApiRest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiRest.DTOs
{
    public class CharacterReadDTO
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


    }
}
