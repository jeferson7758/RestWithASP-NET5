using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(x => x.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = 1,
                FirstName = $"Jeferson_{i}",
                LastName = $"Souza_{i}",
                Address = $"Goiânia_{i}",
                Gender = $"Male_{i}"
            };
        }
       
        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(x => x.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Existis(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(x => x.Id.Equals(person.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
           
            return person;
        }

        private bool Existis(long id)
        {
            return _context.Persons.Any(x => x.Id.Equals(id));
        }
    }
}
