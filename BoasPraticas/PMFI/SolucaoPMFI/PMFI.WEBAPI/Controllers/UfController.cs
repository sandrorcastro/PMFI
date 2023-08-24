using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMFI.Domain.Entities;
using PMFI.Infra.Context;

namespace PMFI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UfController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UfController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Uf
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Uf>>> GetdbUfs()
        {
          if (_context.dbUfs == null)
          {
              return NotFound();
          }
            return await _context.dbUfs.ToListAsync();
        }

        // GET: api/Uf/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Uf>> GetUf(int id)
        {
          if (_context.dbUfs == null)
          {
              return NotFound();
          }
            var uf = await _context.dbUfs.FindAsync(id);

            if (uf == null)
            {
                return NotFound();
            }

            return uf;
        }

        // PUT: api/Uf/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUf(int id, Uf uf)
        {
            if (id != uf.IdUf)
            {
                return BadRequest();
            }

            _context.Entry(uf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UfExists(id))
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

        // POST: api/Uf
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Uf>> PostUf(Uf uf)
        {
          if (_context.dbUfs == null)
          {
              return Problem("Entity set 'ApplicationDbContext.dbUfs'  is null.");
          }
            _context.dbUfs.Add(uf);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UfExists(uf.IdUf))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUf", new { id = uf.IdUf }, uf);
        }

        // DELETE: api/Uf/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUf(int id)
        {
            if (_context.dbUfs == null)
            {
                return NotFound();
            }
            var uf = await _context.dbUfs.FindAsync(id);
            if (uf == null)
            {
                return NotFound();
            }

            _context.dbUfs.Remove(uf);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UfExists(int id)
        {
            return (_context.dbUfs?.Any(e => e.IdUf == id)).GetValueOrDefault();
        }
    }
}
