using Microsoft.AspNetCore.Mvc;
using Personelinformation.Business.Concrete;
using Personelinformation.Data.Concrete.EfCore;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personelinformation.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonelInformationController : ControllerBase
    {
        PersonelInformationManager pm = new PersonelInformationManager(new EfCorePersonelInformationRepository());

        [HttpGet]
        public async Task<IActionResult> GetPersonInformations()
        {
            var personelinformations = await pm.GetAll();
            return Ok(personelinformations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonInformation(int id)
        {
            var personelinformation = await pm.GetById(id);
            if (personelinformation == null)
            {
                return NotFound();
            }
            return Ok(personelinformation);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonInformation(PersonelInformation entity)
        {
            await pm.CreateAsync(entity);
            return CreatedAtAction(nameof(GetPersonInformation), new { id = entity.PersonelInformationID }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var personelinformation = await pm.GetById(id);
            if (personelinformation == null)
            {
                return NotFound();
            }
            await pm.DeleteAsync(personelinformation);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PersonelInformation entity)
        {
            if (id != entity.PersonelInformationID)
            {
                return BadRequest();
            }
            await pm.UpdateAsync(entity);
            return NoContent();
        }
    }
}
