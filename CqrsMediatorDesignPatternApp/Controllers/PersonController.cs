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
            List<Person> persons = await _mediator.Send(new GetAllPersonsQuery());
            return new JsonResult(persons) { StatusCode = 200 };
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetPersonById(Guid id)
        {
            Person response = await _mediator.Send(new GetPersonByIdQuery(id));

            return response is not null ? new JsonResult(response) { StatusCode = 200 } : new JsonResult(response) { StatusCode = 404 };
        }


        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] Person person)
        {
            Person response = await _mediator.Send(new AddPersonCommand(person.FirstName, person.LastName));
            return new JsonResult(response) { StatusCode = 201 };
        }
    }
}