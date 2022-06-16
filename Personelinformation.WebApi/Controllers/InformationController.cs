using Microsoft.AspNetCore.Mvc;
using Personelinformation.Business.Abstract;
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
    public class InformationController : ControllerBase
    {
        InformationManager im = new InformationManager(new EfCoreInformationRepository());
        
        [HttpGet]
        public async Task<IActionResult> GetInformations()
        {
            var informations = await im.GetAllWithDetails();
            return Ok(informations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInformation(int id)
        {
            var information = await im.GetById(id);
            if (information == null)
            {
                return NotFound();
            }
            return Ok(information);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInformation(Information entity)
        {
            await im.CreateAsync(entity);
            return CreatedAtAction(nameof(GetInformation), new { id = entity.InformationID }, entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var information = await im.GetById(id);
            if (information == null)
            {
                return NotFound();
            }
            await im.DeleteAsync(information);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Information entity)
        {
            if (id != entity.InformationID)
            {
                return BadRequest();
            }
            await im.UpdateAsync(entity);
            return NoContent();
        }
    }
}
