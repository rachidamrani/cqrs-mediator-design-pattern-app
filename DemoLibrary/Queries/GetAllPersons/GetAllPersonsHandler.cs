using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Queries.GetAllPersons
{
    public class GetAllPersonsHandler(IDataAccess dataAccess) : IRequestHandler<GetAllPersonsQuery, List<Person>>
    {
        private readonly IDataAccess dataAccess = dataAccess;

        public Task<List<Person>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
        {
            return dataAccess.GetAllPersons();
        }
    }
}