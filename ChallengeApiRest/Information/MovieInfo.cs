using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChallengeApiRest.DTOs;
using ChallengeApiRest.DTOs.MovieDTO;
using ChallengeApiRest.Entities;
namespace ChallengeApiRest.Information
{
    public class MovieInfo : Profile
    {
        public MovieInfo()
        {
            CreateMap<Movie, MovieRead>();
            CreateMap<MovieCreate, Movie>();
            CreateMap<MovieUpdate, Movie>();
            CreateMap<MovieDelete, Movie>();
        }
    }
}
