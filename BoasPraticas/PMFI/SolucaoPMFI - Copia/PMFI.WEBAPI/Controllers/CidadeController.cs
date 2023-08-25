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
    public class CidadeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CidadeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cidade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetdbCidades()
        {
          if (_context.dbCidades == null)
          {
              return NotFound();
          }
            return await _context.dbCidades.ToListAsync();
        }

        // GET: api/Cidade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cidade>> GetCidade(int id)
        {
          if (_context.dbCidades == null)
          {
              return NotFound();
          }
            var cidade = await _context.dbCidades.FindAsync(id);

            if (cidade == null)
            {
                return NotFound();
            }

            return cidade;
        }

        // PUT: api/Cidade/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCidade(int id, Cidade cidade)
        {
            if (id != cidade.IdCidade)
            {
                return BadRequest();
            }

            _context.Entry(cidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CidadeExists(id))
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

        // POST: api/Cidade
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cidade>> PostCidade(Cidade cidade)
        {
          if (_context.dbCidades == null)
          {
              return Problem("Entity set 'ApplicationDbContext.dbCidades'  is null.");
          }
            _context.dbCidades.Add(cidade);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CidadeExists(cidade.IdCidade))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCidade", new { id = cidade.IdCidade }, cidade);
        }

        // DELETE: api/Cidade/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCidade(int id)
        {
            if (_context.dbCidades == null)
            {
                return NotFound();
            }
            var cidade = await _context.dbCidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }

            _context.dbCidades.Remove(cidade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CidadeExists(int id)
        {
            return (_context.dbCidades?.Any(e => e.IdCidade == id)).GetValueOrDefault();
        }
    }
}
