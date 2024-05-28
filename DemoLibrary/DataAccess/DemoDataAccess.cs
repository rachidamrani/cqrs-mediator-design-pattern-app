using DemoLibrary.DataAccess.Models;

namespace DemoLibrary;

public class DemoDataAccess : IDataAccess
{
    List<Person> people = new List<Person> {
        new Person(Guid.Parse("71c2b7f8-ce8f-4cfc-a92d-28c146826831"), "John","Doe"),
        new Person(Guid.Parse("5e498223-6f2d-47ae-85b7-cc8ca81e6c3d"), "Sue","Storm"),
    };


    public async Task<Person?> GetPersonById(Guid id)
    {
        Person? person = people.FirstOrDefault(x => x.Id == id);

        return await Task.FromResult(person);
    }


    public async Task<List<Person>> GetAllPersons() => await Task.FromResult(people);

    public async Task<Person> AddPerson(string firstname, string lastname)
    {
        Person newPerson = new Person(Guid.NewGuid(), firstname, lastname);

        people.Add(newPerson);

        return await Task.FromResult(newPerson);
    }
}
