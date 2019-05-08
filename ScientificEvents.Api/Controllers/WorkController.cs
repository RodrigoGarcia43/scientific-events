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
    public class WorkController: ControllerBase
    {
        private readonly IWorkService _workService;

        public WorkController (IWorkService workService)
        {
            _workService = workService;
        }

        // GET api/Work
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkDto>>> GetAllAsync()
        {
            var works = await _workService.ListAsync;
            return works;
        }

        // GET api/Work/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkDto>> GetAsync(int id)
        {
            var work = await _workService.GetAsync;
            return work;
        }

        // POST api/Work
        [HttpPost]
        public async Task<ActionResult<NewWorkDto>> CreateAsync(NewWorkDto newWork)
        {
            var work = await _workService.CreateAsync(newWork);

            return CreatedAtAction(nameof(GetAsync), new { id = work.Id }, work);
        }

        // DELETE api/Work
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _workService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}