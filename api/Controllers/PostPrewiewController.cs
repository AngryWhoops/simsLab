using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostPrewiewController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public PostPrewiewController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/PostPrewiew
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostPrewiew>>> GetPostPrewiews()
        {
          if (_context.PostPrewiews == null)
          {
              return NotFound();
          }
            return await _context.PostPrewiews.ToListAsync();
        }

        // GET: api/PostPrewiew/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostPrewiew>> GetPostPrewiew(long id)
        {
          if (_context.PostPrewiews == null)
          {
              return NotFound();
          }
            var postPrewiew = await _context.PostPrewiews.FindAsync(id);

            if (postPrewiew == null)
            {
                return NotFound();
            }

            return postPrewiew;
        }

        // PUT: api/PostPrewiew/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostPrewiew(long id, PostPrewiew postPrewiew)
        {
            if (id != postPrewiew.Id)
            {
                return BadRequest();
            }

            _context.Entry(postPrewiew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostPrewiewExists(id))
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

        // POST: api/PostPrewiew
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PostPrewiew>> PostPostPrewiew(PostPrewiew postPrewiew)
        {
          if (_context.PostPrewiews == null)
          {
              return Problem("Entity set 'ApplicationContext.PostPrewiews'  is null.");
          }
            _context.PostPrewiews.Add(postPrewiew);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostPrewiew", new { id = postPrewiew.Id }, postPrewiew);
        }

        // DELETE: api/PostPrewiew/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostPrewiew(long id)
        {
            if (_context.PostPrewiews == null)
            {
                return NotFound();
            }
            var postPrewiew = await _context.PostPrewiews.FindAsync(id);
            if (postPrewiew == null)
            {
                return NotFound();
            }

            _context.PostPrewiews.Remove(postPrewiew);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostPrewiewExists(long id)
        {
            return (_context.PostPrewiews?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
