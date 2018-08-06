namespace SA.GA.DataAccess.Repository
{
    #region Usings
    using System.Collections.Generic;
    #endregion
    public interface IRepository<T> where T: class
    {
        void Create(T item);
        void Delete(int id);
        void Update(T item);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}