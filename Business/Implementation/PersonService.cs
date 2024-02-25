using RestAPI.Models;
using RestAPI.Repository;

namespace RestAPI.Business.Implementation;

public class PersonBusiness : IPersonBusiness
{
    private IPersonRepository _repository;

    public PersonBusiness(IPersonRepository repository)
    {
        _repository = repository;
    }

    public async Task<Person> CreatePesonAsyn(Person person)
    {
       return await _repository.CreatePesonAsyn(person);
    }

    public async Task DeletePerson(int Id)
    {
        await _repository.DeletePerson(Id);
    }

    public async Task<List<Person>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Person> GetByIdAsyn(int Id)
    {
        return await _repository.GetByIdAsyn(Id);
    }

    public async Task<Person> UpdatePerson(Person person)
    {
        return await _repository.UpdatePerson(person);
    }
}