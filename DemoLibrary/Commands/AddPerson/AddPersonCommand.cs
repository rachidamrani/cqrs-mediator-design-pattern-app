using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Commands.AddPerson
{
    public record AddPersonCommand(string FirstName, string LastName) : IRequest<Person>;
}