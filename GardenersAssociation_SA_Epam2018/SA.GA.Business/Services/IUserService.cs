using SA.GA.Common.Models;
using System.Collections.Generic;

namespace SA.GA.Business.Services
{
    public interface IUserService
    {
        User GetUserById(int id);

        void DeleteUserByUserId(int id);

        IEnumerable<User> GetUsersList();

        void SaveUser(User model);

        void UpdateUser(User model);

    }
}
