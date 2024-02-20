using System.Runtime.CompilerServices;
using RestAPI.Models;

namespace RestAPI.Service.Implementation;

public class PersonService : IPersonService
{
    private volatile int _cout;
    public async Task<Person> CreatePesonAsyn(Person person)
    {
        return await Task.FromResult(person);
    }

    public async void DeletePerson(int Id)
    {
       
    }

    public async Task<List<Person>> GetAllAsync()
    {
        List<Person> persons = new();
        for (int i = 0; i < 8; i++)
            persons.Add(MockPerson(i));

        return  await Task.FromResult(persons);
    }



    public async Task<Person> GetByIdAsyn(int Id)
    {
        return await Task.FromResult(new Person(){
            Id = IncrementAndGet(),
            FirstName = "João",
            LastName = "Rhasseller",
            Gender = "M"
        });
    }

    public async Task<Person> UpdatePerson(Person person)
    {
        return await Task.FromResult(person);
    }
    
    private Person MockPerson(int i)
    {
        return new Person(){
            Id = IncrementAndGet(),
            FirstName = "João",
            LastName = "Rhasseller",
            Gender = "M"
        };
    }

    private int IncrementAndGet()
    {
        return Interlocked.Increment(ref _cout);
    }
}