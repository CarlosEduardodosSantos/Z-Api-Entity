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
    public class SiempsController : ControllerBase
    {
        private readonly ZipInCloud20Context _context;

        public SiempsController(ZipInCloud20Context context)
        {
            _context = context;
        }

        // GET: api/Siemps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Siemp>>> GetSiemps()
        {
            return await _context.Siemps.ToListAsync();
        }

        // GET: api/Siemps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Siemp>> GetSiemp(int id)
        {
            var siemp = await _context.Siemps.FindAsync(id);

            if (siemp == null)
            {
                return NotFound();
            }

            return siemp;
        }

        // PUT: api/Siemps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSiemp(int id, Siemp siemp)
        {
            if (id != siemp.Loja)
            {
                return BadRequest();
            }

            _context.Entry(siemp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiempExists(id))
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

        // POST: api/Siemps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Siemp>> PostSiemp(Siemp siemp)
        {
            _context.Siemps.Add(siemp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SiempExists(siemp.Loja))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSiemp", new { id = siemp.Loja }, siemp);
        }

        // DELETE: api/Siemps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSiemp(int id)
        {
            var siemp = await _context.Siemps.FindAsync(id);
            if (siemp == null)
            {
                return NotFound();
            }

            _context.Siemps.Remove(siemp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SiempExists(int id)
        {
            return _context.Siemps.Any(e => e.Loja == id);
        }
    }
}
