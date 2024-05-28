using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record AddPersonCommand(string FirstName, string LastName) : IRequest<Person>;
}