using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChallengeApiRest.DTOs;
using ChallengeApiRest.DTOs.CharacterDTO;
using ChallengeApiRest.Entities;
using ChallengeApiRest.Models;

namespace ChallengeApiRest.Information
{
    public class CharacterInfo : Profile
    {
        public CharacterInfo()
        {

            CreateMap<Character, CharacterReadDTO>();
            CreateMap<Character, CharacterDetails>();
            CreateMap<CharacterCreate, Character>();
            CreateMap<CharacterUpdateDTO, Character>();
            CreateMap<CharacterDelete, Character>();

        }

    }
}
