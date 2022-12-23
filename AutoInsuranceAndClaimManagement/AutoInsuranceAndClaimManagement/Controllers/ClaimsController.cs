using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoInsuranceAndClaimManagement.Context;
using AutoInsuranceAndClaimManagement.Models;

namespace AutoInsuranceAndClaimManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly AutoInsuranceAndClaimManagementDbContext _context;

        public ClaimsController(AutoInsuranceAndClaimManagementDbContext context)
        {
            _context = context;
        }

        // GET: api/Claims
        [HttpGet]
        public IEnumerable<Claim> GetClaim()
        {
            return _context.Claim;
        }

        // GET: api/Claims/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClaim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var claim = await _context.Claim.FindAsync(id);

            if (claim == null)
            {
                return NotFound();
            }

            return Ok(claim);
        }

        // PUT: api/Claims/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClaim([FromRoute] int id, [FromBody] Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != claim.Claim_Id)
            {
                return BadRequest();
            }

            _context.Entry(claim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimExists(id))
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

        // POST: api/Claims
        [HttpPost]
        public async Task<IActionResult> PostClaim([FromBody] Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Claim.Add(claim);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClaim", new { id = claim.Claim_Id }, claim);
        }

        // DELETE: api/Claims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClaim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var claim = await _context.Claim.FindAsync(id);
            if (claim == null)
            {
                return NotFound();
            }

            _context.Claim.Remove(claim);
            await _context.SaveChangesAsync();

            return Ok(claim);
        }

        private bool ClaimExists(int id)
        {
            return _context.Claim.Any(e => e.Claim_Id == id);
        }
    }
}