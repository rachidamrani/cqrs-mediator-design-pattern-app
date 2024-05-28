namespace DemoLibrary.DataAccess.Models
{
    public interface IDataAccess
    {
        Task<Person?> GetPersonById(Guid id);
        Task<List<Person>> GetAllPersons();
        Task<Person> AddPerson(string firstname, string lastname);
    }
}