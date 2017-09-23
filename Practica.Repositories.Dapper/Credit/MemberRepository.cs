using Practica.Models;
using Practica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Repositories.Dapper.Credit
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(string connectionString) : base(connectionString)
        {
        }

    }
}
