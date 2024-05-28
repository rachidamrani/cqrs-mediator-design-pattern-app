using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Queries.GetPersonById
{
    public record GetPersonByIdQuery(Guid Id) : IRequest<Person>;
}