using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChallengeApiRest.Context;
using ChallengeApiRest.DTOs;
using ChallengeApiRest.Repositories;
using ChallengeApiRest.Models;

namespace ChallengeApiRest.Controllers
{
    [Route("/character")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DisneyDBContext _context;

        public CharacterController(IRepository <Character, int> CharacterRepository)
        {
            
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterReadDTO>>> Characters()
        {

            return await _context.CharacterReadDTO.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterReadDTO>> GetCharacterReadDTO(int id)
        {
            var characterReadDTO = await _context.CharacterReadDTO.FindAsync(id);

            if (characterReadDTO == null)
            {
                return NotFound();
            }

            return characterReadDTO;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterReadDTO(int id, CharacterReadDTO characterReadDTO)
        {
            if (id != characterReadDTO.id)
            {
                return BadRequest();
            }

            _context.Entry(characterReadDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterReadDTOExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<CharacterReadDTO>> PostCharacterReadDTO(CharacterReadDTO characterReadDTO)
        {
            _context.CharacterReadDTO.Add(characterReadDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterReadDTO", new { id = characterReadDTO.id }, characterReadDTO);
        }

        // DELETE: api/Character/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterReadDTO(int id)
        {
            var characterReadDTO = await _context.CharacterReadDTO.FindAsync(id);
            if (characterReadDTO == null)
            {
                return NotFound();
            }

            _context.CharacterReadDTO.Remove(characterReadDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterReadDTOExists(int id)
        {
            return _context.CharacterReadDTO.Any(e => e.id == id);
        }
    }
}
