using RestAPI.Models;

namespace RestAPI.Service;

public interface IPersonService
{
     Task<Person> CreatePesonAsyn(Person person);
     Task<Person> GetByIdAsyn(int Id);
     Task<Person> UpdatePerson(Person person);
     Task<List<Person>> GetAllAsync();
     void DeletePerson(int Id);
}