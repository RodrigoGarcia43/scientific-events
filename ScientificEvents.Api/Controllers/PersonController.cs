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
    public class PersonController: ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController (IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAllAsync()
        {
            var persons = await _personService.ListAsync;
            return persons;
        }

        // GET api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDto>> GetAsync(int id)
        {
            var person = await _personService.GetAsync;
            return person;
        }

        // POST api/Person
        [HttpPost]
        public async Task<ActionResult<NewPersonDto>> CreateAsync(NewPersonDto newPerson)
        {
            var person = await _personService.CreateAsync(newPerson);

            return CreatedAtAction(nameof(GetAsync), new { id = person.Id }, person);
        }

        // DELETE api/person
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _personService.Delete(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}