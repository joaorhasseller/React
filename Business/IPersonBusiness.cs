using RestAPI.Models;

namespace RestAPI.Business;

public interface IPersonBusiness
{
     Task<Person> CreatePesonAsyn(Person person);
     Task<Person> GetByIdAsyn(int Id);
     Task<Person> UpdatePerson(Person person);
     Task<List<Person>> GetAllAsync();
     Task DeletePerson(int Id);
}