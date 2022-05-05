using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity.Api.Zip;

namespace Entity.Api.Zip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Caixa1Controller : ControllerBase
    {
        private readonly ZipInCloud20Context _context;

        public Caixa1Controller(ZipInCloud20Context context)
        {
            _context = context;
        }

        // GET: api/Caixa1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caixa1>>> GetCaixa1s()
        {
            return await _context.Caixa1s.ToListAsync();
        }

        // GET: api/Caixa1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caixa1>> GetCaixa1(int id)
        {
            var caixa1 = await _context.Caixa1s.FindAsync(id);

            if (caixa1 == null)
            {
                return NotFound();
            }

            return caixa1;
        }

        // PUT: api/Caixa1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaixa1(int id, Caixa1 caixa1)
        {
            if (id != caixa1.NroCx)
            {
                return BadRequest();
            }

            _context.Entry(caixa1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Caixa1Exists(id))
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

        // POST: api/Caixa1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caixa1>> PostCaixa1(Caixa1 caixa1)
        {
            _context.Caixa1s.Add(caixa1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Caixa1Exists(caixa1.NroCx))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCaixa1", new { id = caixa1.NroCx }, caixa1);
        }

        // DELETE: api/Caixa1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaixa1(int id)
        {
            var caixa1 = await _context.Caixa1s.FindAsync(id);
            if (caixa1 == null)
            {
                return NotFound();
            }

            _context.Caixa1s.Remove(caixa1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Caixa1Exists(int id)
        {
            return _context.Caixa1s.Any(e => e.NroCx == id);
        }
    }
}
