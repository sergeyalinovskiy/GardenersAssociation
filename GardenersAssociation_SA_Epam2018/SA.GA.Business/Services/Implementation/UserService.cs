namespace SA.GA.Business.Services.Implementation
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SA.GA.Common.Models;
    using SA.GA.DataAccess.Repository;
    using SA.GA.DataAccess.Repository.Implementation;
    #endregion
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        private readonly IHistoryRepository _historyRepository;

        private readonly IPlotRepository _plotRepository;

        public UserService(IUserRepository userRepository, IHistoryRepository historyRepository, IPlotRepository plotRepository)
        {
            if (userRepository == null)
            {
                throw new NullReferenceException();
            }
            if (historyRepository == null)
            {
                throw new NullReferenceException();
            }
            if (plotRepository == null)
            {
                throw new NullReferenceException();
            }
            _userRepository = userRepository;
            _historyRepository = historyRepository;
            _plotRepository = plotRepository;
        }

        public void DeleteUserByUserId(int id)
        {
            if (id <1)
            {
                throw new Exception();
            }
            User user=_userRepository.GetById(id);
            user.Status = false;
            _userRepository.Update(user);
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

        public IEnumerable<Plot> GetUserPlots(int id)
        {
            IEnumerable<History> historys;
            historys = _historyRepository.GetAll();
            int [] plotsId =historys.Where(m => m.UserId == id).Select(m => m.PlotId).ToArray();
            List<Plot> plots = new List<Plot>();

            foreach(int i in plotsId)
            {
                plots.Add(_plotRepository.GetById(i));
            }
            return plots;
        } 
    }
}
