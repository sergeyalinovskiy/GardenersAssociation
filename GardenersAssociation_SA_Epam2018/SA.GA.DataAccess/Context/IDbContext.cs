namespace SA.GA.DataAccess.Context
{
    #region Usings
        using System.Collections.Generic;
    #endregion
    public interface IDbContext<T> where T: class
    {
        ICollection<T> GetAll();
        bool Create(T item);
        bool Update(T item);
        bool Delete(int id);
        T GetById(int id);
    }
}