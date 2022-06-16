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
        public class DetailInformationController : ControllerBase
        {
            DetailInformationManager dm = new DetailInformationManager(new EfCoreDetailInformationRepository());

            [HttpGet]
            public async Task<IActionResult> GetInformations()
            {
                var details = await dm.GetAll();
                 return Ok(details);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetInformation(int id)
            {
                var detail = await dm.GetById(id);
                if (detail == null)
                {
                    return NotFound();
                }
                return Ok(detail);
            }

            [HttpPost]
            public async Task<IActionResult> CreateInformation(DetailInformation entity)
            {
                await dm.CreateAsync(entity);
                return CreatedAtAction(nameof(GetInformation), new { id = entity.DetailInformationID }, entity);
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {

                var information = await dm.GetById(id);
                if (information == null)
                {
                    return NotFound();
                }
                await dm.DeleteAsync(information);
                return NoContent();
            }
            [HttpPut("{id}")]
            public async Task<IActionResult> Update(int id, DetailInformation entity)
            {
                if (id != entity.DetailInformationID)
                {
                    return BadRequest();
                }
                await dm.UpdateAsync(entity);
                return NoContent();
            }
        }
    }

