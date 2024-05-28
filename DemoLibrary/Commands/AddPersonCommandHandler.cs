using DemoLibrary.DataAccess.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand, Person>
    {
        private readonly IDataAccess _dataAccess;

        public AddPersonCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<Person> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return await _dataAccess.AddPerson(request.FirstName, request.LastName);
        }
    }
}