using SA.GA.Common.Models;
using System.Collections.Generic;

namespace SA.GA.DataAccess.Repository
{
    public interface IUserRepository
    {
        void Create(User item);
        void Delete(int id);
        void Update(User item);
        User GetById(int id);
        IEnumerable<User> GetAll();
    }
}
