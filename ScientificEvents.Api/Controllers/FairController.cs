using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScientificEvents.API.Domain.Services;
using ScientificEvents.API.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using ScientificEvents.Core.Services;
using ScientificEvents.Core.Dtos;

namespace ScientificEvents.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FairController: ControllerBase
    {
        private readonly IFairService _fairService;

        public FairController (IFairService FairService)
        {
            _fairService = fairService;
        }

        // GET api/Fair
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FairDto>>> GetAllAsync()
        {
            var fairs = await _fairService.ListAsync;
            return fairs;
        }

        // GET api/Fair/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FairDto>> GetAsync(int id)
        {
            var fair = await _fairService.GetAsync;
            return fair;
        }

        // POST api/Fair
        [HttpPost]
        public async Task<ActionResult<NewFairDto>> CreateAsync(NewFairDto newFair)
        {
            var fair = await _fairService.CreateAsync(newFair);

            return CreatedAtAction(nameof(GetAsync), new { id = fair.Id }, fair);
        }

        // DELETE api/Fair
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _fairService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}