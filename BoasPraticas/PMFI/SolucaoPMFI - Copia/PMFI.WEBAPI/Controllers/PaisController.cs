using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMFI.Application.Interfaces;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;
using PMFI.Infra.Context;

namespace PMFI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IPaisAppService paisAppService;
        public PaisController(ApplicationDbContext context, IPaisAppService paisAppService)
        {
            _context = context;
            this.paisAppService = paisAppService;
        }

        // GET: api/Pais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaisViewModel>>> GetdbPaises()
        {
          if (paisAppService == null)
          {
              return NotFound();
          }
            return Ok(await paisAppService.ListAsync());
        }

        // GET: api/Pais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pais>> GetPais(int id)
        {
          if (_context.dbPaises == null)
          {
              return NotFound();
          }
            var pais = await _context.dbPaises.FindAsync(id);

            if (pais == null)
            {
                return NotFound();
            }

            return pais;
        }

        // PUT: api/Pais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais(int id, Pais pais)
        {
            if (id != pais.IdPais)
            {
                return BadRequest();
            }

            _context.Entry(pais).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisExists(id))
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

        // POST: api/Pais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pais>> PostPais(Pais pais)
        {
          if (_context.dbPaises == null)
          {
              return Problem("Entity set 'ApplicationDbContext.dbPaises'  is null.");
          }
            _context.dbPaises.Add(pais);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PaisExists(pais.IdPais))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPais", new { id = pais.IdPais }, pais);
        }

        // DELETE: api/Pais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePais(int id)
        {
            if (_context.dbPaises == null)
            {
                return NotFound();
            }
            var pais = await _context.dbPaises.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }

            _context.dbPaises.Remove(pais);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaisExists(int id)
        {
            return (_context.dbPaises?.Any(e => e.IdPais == id)).GetValueOrDefault();
        }
    }
}
