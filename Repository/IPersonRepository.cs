using RestAPI.Models;

namespace RestAPI.Repository;

public interface IPersonRepository
{
     Task<Person> CreatePesonAsyn(Person person);
     Task<Person> GetByIdAsyn(int Id);
     Task<Person> UpdatePerson(Person person);
     Task<List<Person>> GetAllAsync();
     Task DeletePerson(int Id);
     Task<bool> Exist(int id);
}