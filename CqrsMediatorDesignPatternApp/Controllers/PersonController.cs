using DemoLibrary.Commands.AddPerson;
using DemoLibrary.DataAccess.Models;
using DemoLibrary.Queries.GetAllPersons;
using DemoLibrary.Queries.GetPersonById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatorDesignPatternApp.Controllers
{
    [ApiController]
    [Route("api/persons")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok(await _mediator.Send(new GetAllPersonsQuery()));
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetPersonById(Guid id)
        {
            Person person = await _mediator.Send(new GetPersonByIdQuery(id));
            return person is not null ? Ok(person) : NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] Person person)
        {
            return Ok(await _mediator.Send(new AddPersonCommand(person.FirstName, person.LastName)));
        }
    }
}