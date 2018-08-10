namespace SA.GA.Business.Services.Implementation
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using SA.GA.Common.Models;
    using SA.GA.DataAccess.Repository;
    #endregion
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            if (userRepository == null)
            {
                throw new NullReferenceException();
            }
            _userRepository = userRepository;
        }

        public void DeleteUserByUserId(int id)
        {
            if (id <1)
            {
                throw new Exception();
            }
            _userRepository.Delete(id);
        }

        public User GetUserById(int id)
        {
            if (id < 1)
            {
                throw new Exception();
            }
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> GetUsersList()
        {
            return _userRepository.GetAll();
        }

        public void SaveUser(User model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _userRepository.Create(model);
        }

        public void UpdateUser(User model)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }
            _userRepository.Update(model);
        }
    }
}
