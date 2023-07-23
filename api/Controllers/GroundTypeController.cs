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
    public class GroundTypeController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public GroundTypeController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/GroundType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroundType>>> GetGroundTypes()
        {
          if (_context.GroundTypes == null)
          {
              return NotFound();
          }
            return await _context.GroundTypes.ToListAsync();
        }

        // GET: api/GroundType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroundType>> GetGroundType(long id)
        {
          if (_context.GroundTypes == null)
          {
              return NotFound();
          }
            var groundType = await _context.GroundTypes.FindAsync(id);

            if (groundType == null)
            {
                return NotFound();
            }

            return groundType;
        }

        // PUT: api/GroundType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroundType(long id, GroundType groundType)
        {
            if (id != groundType.Id)
            {
                return BadRequest();
            }

            _context.Entry(groundType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroundTypeExists(id))
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

        // POST: api/GroundType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GroundType>> PostGroundType(GroundType groundType)
        {
          if (_context.GroundTypes == null)
          {
              return Problem("Entity set 'ApplicationContext.GroundTypes'  is null.");
          }
            _context.GroundTypes.Add(groundType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroundType", new { id = groundType.Id }, groundType);
        }

        // DELETE: api/GroundType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroundType(long id)
        {
            if (_context.GroundTypes == null)
            {
                return NotFound();
            }
            var groundType = await _context.GroundTypes.FindAsync(id);
            if (groundType == null)
            {
                return NotFound();
            }

            _context.GroundTypes.Remove(groundType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GroundTypeExists(long id)
        {
            return (_context.GroundTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
