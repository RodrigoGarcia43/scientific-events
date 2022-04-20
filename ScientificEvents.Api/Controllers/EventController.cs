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
    public class EventController: ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController (IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET api/Event
        [HttpGet]
        public async Task<ActionResult<ICollection<SummaryEventDto>>> GetAllAsync()
        {
            var events = await _eventService.ListAsync();
            return events;
        }

        // GET api/Event/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventDto>> GetAsync(string code)
        {
            var event_ = await _eventService.GetAsync(code);
            return event_;
        }

        // POST api/Event
        [HttpPost]
        public async Task<ActionResult<NewEventDto>> CreateAsync(NewEventDto newEvent)
        {
            var event_ = await _eventService.CreateAsync(newEvent);

            return CreatedAtAction(nameof(GetAsync), new { id = event_.Code }, event_);
        }

        // DELETE api/Event
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _eventService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}