using ChallengeApiRest.Entities;
using ChallengeApiRest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ChallengeApiRest.DTOs.MovieDTO;
using ChallengeApiRest.DTOs;
using ChallengeApiRest.DTOs.CharacterDTO;


namespace ChallengeApiRest.Context
{
    public class DisneyDBContext : DbContext
    {
        public DisneyDBContext(DbContextOptions<DisneyDBContext> options) : base(options)
        {

        }


       public DbSet<Character> Character { get; set; }
        public DbSet <Movie> Movies { get; set; }
        public DbSet<Series> _Series { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ChallengeApiRest.DTOs.MovieDTO.MovieRead> MovieRead { get; set; }
        public DbSet<ChallengeApiRest.DTOs.CharacterReadDTO> CharacterReadDTO { get; set; }
        public DbSet<ChallengeApiRest.DTOs.CharacterDTO.CharacterDetails> CharacterDetails { get; set; }
        public IEnumerable<Character> Characters { get; internal set; }
    }


    }
