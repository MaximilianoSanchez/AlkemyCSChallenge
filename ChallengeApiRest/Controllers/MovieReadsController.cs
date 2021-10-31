using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChallengeApiRest.Context;
using ChallengeApiRest.DTOs.MovieDTO;

namespace ChallengeApiRest.Controllers
{
    [Route("GET /movies")]
    [ApiController]
    public class MovieReadsController : ControllerBase
    {
        private readonly DisneyDBContext _context;

        public MovieReadsController(DisneyDBContext context)
        {
            _context = context;
        }

        // GET: api/MovieReads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieRead>>> GetMovieRead()
        {
            return await _context.MovieRead.ToListAsync();
        }

        // GET: api/MovieReads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieRead>> GetMovieRead(int id)
        {
            var movieRead = await _context.MovieRead.FindAsync(id);

            if (movieRead == null)
            {
                return NotFound();
            }

            return movieRead;
        }

        // PUT: api/MovieReads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieRead(int id, MovieRead movieRead)
        {
            if (id != movieRead.id)
            {
                return BadRequest();
            }

            _context.Entry(movieRead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieReadExists(id))
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

        // POST: api/MovieReads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieRead>> PostMovieRead(MovieRead movieRead)
        {
            _context.MovieRead.Add(movieRead);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieRead", new { id = movieRead.id }, movieRead);
        }

        // DELETE: api/MovieReads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieRead(int id)
        {
            var movieRead = await _context.MovieRead.FindAsync(id);
            if (movieRead == null)
            {
                return NotFound();
            }

            _context.MovieRead.Remove(movieRead);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieReadExists(int id)
        {
            return _context.MovieRead.Any(e => e.id == id);
        }
    }
}
