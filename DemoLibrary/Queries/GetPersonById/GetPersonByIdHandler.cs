using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Queries.GetPersonById
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IDataAccess _dataAccess;

        public GetPersonByIdHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return _dataAccess.GetPersonById(request.Id)!;
        }
    }
}