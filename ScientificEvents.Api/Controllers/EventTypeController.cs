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
    public class EventTypeController: ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;

        public EventTypeController (IEventTypeService eventTypeService)
        {
            _eventTypeService = eventTypeService;
        }

        // GET api/EventType
        [HttpGet]
        public async Task<ActionResult<ICollection<EventTypeDto>>> GetAllAsync()
        {
            var eventTypes = await _eventTypeService.ListAsync;
            return eventTypes;
        }

        // GET api/EventType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventTypeDto>> GetAsync(int id)
        {
            var eventType = await _eventTypeService.GetAsync;
            return eventType;
        }

        // POST api/EventType
        [HttpPost]
        public async Task<ActionResult<NewEventTypeDto>> CreateAsync(NewEventTypeDto newEventType)
        {
            var eventType = await _eventTypeService.CreateAsync(newEventType);

            return CreatedAtAction(nameof(GetAsync), new { id = eventType.Id }, eventType);
        }

        // DELETE api/EventType
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _eventTypeService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}