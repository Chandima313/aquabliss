using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using aquabliss;

namespace aquabliss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInsController : ControllerBase
    {
        private readonly AquablissDbContext _context = new();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LogIn>>> GetLogIn()
        {
            return await _context.LogIn.ToListAsync();
        }

        // GET: api/LogIns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LogIn>> GetLogIn(string id)
        {
            var logIn = await _context.LogIn.FindAsync(id);

            if (logIn == null)
            {
                return NotFound();
            }

            return logIn;
        }

        // PUT: api/LogIns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogIn(string id, LogIn logIn)
        {
            if (id != logIn.Login_ID)
            {
                return BadRequest();
            }

            _context.Entry(logIn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogInExists(id))
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

        // POST: api/LogIns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LogIn>> PostLogIn(LogIn logIn)
        {
            _context.LogIn.Add(logIn);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LogInExists(logIn.Login_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLogIn", new { id = logIn.Login_ID }, logIn);
        }

        // DELETE: api/LogIns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogIn(string id)
        {
            var logIn = await _context.LogIn.FindAsync(id);
            if (logIn == null)
            {
                return NotFound();
            }

            _context.LogIn.Remove(logIn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogInExists(string id)
        {
            return _context.LogIn.Any(e => e.Login_ID == id);
        }
    }
}
