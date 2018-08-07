using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Repository
{
    public interface IElectricityRepository
    {
        void Create(Electricity item);
        void Delete(int id);
        void Update(Electricity item);
        Electricity GetById(int id);
        IEnumerable<Electricity> GetAll();
    }
}
