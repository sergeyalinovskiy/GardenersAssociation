using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Repository.Implementation
{
    public interface IRateRepository
    {
        void Create(Rate item);
        void Delete(int id);
        void Update(Rate item);
        Rate GetById(int id);
        IEnumerable<Rate> GetAll();
    }
}
