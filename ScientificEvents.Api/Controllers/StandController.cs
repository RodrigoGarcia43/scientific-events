using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScientificEvents.Core.Services;
using ScientificEvents.Core.Dtos;

namespace ScientificEvents.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandController: ControllerBase
    {
        private readonly IStandService _standService;

        public StandController (IStandService standService)
        {
            _standService = standService;
        }

        // GET api/Stand
        [HttpGet]
        public async Task<ActionResult<ICollection<StandDto>>> GetAllAsync()
        {
            var stands = await _standService.ListAsync;
            return stands;
        }

        // GET api/Stand/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StandDto>> GetAsync(int id)
        {
            var stand = await _standService.GetAsync;
            return stand;
        }

        // POST api/Stand
        [HttpPost]
        public async Task<ActionResult<NewStandDto>> CreateAsync(NewStandDto newStand)
        {
            var stand = await _standService.CreateAsync(newStand);

            return CreatedAtAction(nameof(GetAsync), new { id = stand.Code }, stand);
        }

        // DELETE api/Stand
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _standService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}