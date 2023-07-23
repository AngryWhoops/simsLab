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
    public class AppFileController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public AppFileController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/AppFile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppFile>>> GetAppFiles()
        {
            if (_context.AppFiles == null)
            {
                return NotFound();
            }
            return await _context.AppFiles.ToListAsync();
        }

        // GET: api/AppFile/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppFile>> GetAppFile(long id)
        {
            if (_context.AppFiles == null)
            {
                return NotFound();
            }
            var @AppFile = await _context.AppFiles.FindAsync(id);

            if (@AppFile == null)
            {
                return NotFound();
            }

            return @AppFile;
        }

        // PUT: api/AppFile/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppFile(long id, AppFile @AppFile)
        {
            if (id != @AppFile.Id)
            {
                return BadRequest();
            }

            _context.Entry(@AppFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppFileExists(id))
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

        // POST: api/AppFile
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppFile>> PostAppFile(AppFile @AppFile)
        {
            if (_context.AppFiles == null)
            {
                return Problem("Entity set 'ApplicationContext.AppFiles'  is null.");
            }
            _context.AppFiles.Add(@AppFile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppFile", new { id = @AppFile.Id }, @AppFile);
        }

        // DELETE: api/AppFile/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppFile(long id)
        {
            if (_context.AppFiles == null)
            {
                return NotFound();
            }
            var @AppFile = await _context.AppFiles.FindAsync(id);
            if (@AppFile == null)
            {
                return NotFound();
            }

            _context.AppFiles.Remove(@AppFile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppFileExists(long id)
        {
            return (_context.AppFiles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
