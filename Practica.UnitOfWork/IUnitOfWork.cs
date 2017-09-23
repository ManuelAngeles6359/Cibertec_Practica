using Practica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.UnitOfWork
{
    public interface IUnitOfWork
    {


        ICorporationRepository Corporations { get; }
        IMemberRepository Members { get; }


    }
}
