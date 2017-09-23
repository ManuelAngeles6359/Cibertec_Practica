using Practica.Models;
using Practica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Repositories.Dapper.Credit
{
    public class CorporationRepository : Repository<Corporation>, ICorporationRepository
    {
        public CorporationRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
