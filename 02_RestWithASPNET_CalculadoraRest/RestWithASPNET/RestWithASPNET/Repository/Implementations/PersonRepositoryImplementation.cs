using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {

        private MySqlContext _context;

        public PersonRepositoryImplementation(MySqlContext context)
        {
            _context = context;
        }
        
    }
}
