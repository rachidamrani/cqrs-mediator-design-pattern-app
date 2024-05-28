using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Queries.GetAllPersons
{
    public record GetAllPersonsQuery() : IRequest<List<Person>>;
}