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
    public class ParticipationTypeController: ControllerBase
    {
        private readonly IParticipationTypeService _participationTypeService;

        public ParticipationTypeController (IParticipationTypeService ParticipationTypeService)
        {
            _participationTypeService = participationTypeService;
        }

        // GET api/ParticipationType
        [HttpGet]
        public async Task<ActionResult<ICollection<ParticipationTypeDto>>> GetAllAsync()
        {
            var participationTypes = await _participationTypeService.ListAsync;
            return participationTypes;
        }

        // GET api/ParticipationType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParticipationTypeDto>> GetAsync(int id)
        {
            var participationType = await _participationTypeService.GetAsync;
            return participationType;
        }

        // POST api/ParticipationType
        [HttpPost]
        public async Task<ActionResult<NewParticipationTypeDto>> CreateAsync(NewParticipationTypeDto newParticipationType)
        {
            var participationType = await _participationTypeService.CreateAsync(newParticipationType);

            return CreatedAtAction(nameof(GetAsync), new { id = participationType.Name }, participationType);
        }

        // DELETE api/ParticipationType
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _participationTypeService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}