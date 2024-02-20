using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using RestAPI.Data;
using RestAPI.Models;

namespace RestAPI.Service.Implementation;

public class PersonService : IPersonService
{
    private AppDbContext _context;

    public PersonService(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<Person> CreatePesonAsyn(Person person)
    {
        try
        {
            await _context.AddAsync(person);
            await _context.SaveChangesAsync();
            return person;
        }
        catch (OperationCanceledException ex)
        {
            throw;
        }
    }

    public async void DeletePerson(int Id)
    {
        var person = await _context.Set<Person>().FirstOrDefaultAsync(x => x.Id.Equals(Id));
        if(person is null)
            throw new KeyNotFoundException("Pessoa não encontrada");

        _context.Set<Person>().Remove(person);
    }

    public async Task<List<Person>> GetAllAsync()
    {
        var teste = await _context.Set<Person>().ToListAsync();
        return teste;
    }

    public async Task<Person> GetByIdAsyn(int Id)
    {
        return await _context.Set<Person>().FirstOrDefaultAsync(x => x.Id.Equals(Id))
        ?? throw new KeyNotFoundException("Não foi encontrado nenhuma Pessoa");
    }

    public async Task<Person> UpdatePerson(Person person)
    {
        if(await Exist(person.Id))
        {
            try
            {   
                var entity = await _context.Set<Person>().FirstOrDefaultAsync(x => x.Id.Equals(person.Id));
                if(entity is not null)
                {
                    _context.Entry(entity).CurrentValues.SetValues(person);
                    await _context.SaveChangesAsync();
                }
                 return person;
            }
            catch (OperationCanceledException ex)
            {
                throw;
            }
        }
        else
            throw new KeyNotFoundException("Pessoa não existe");
    }

    private async Task<bool> Exist(int id)
    {
        return await _context.Set<Person>().AnyAsync(x => x.Id.Equals(id));
    }
}