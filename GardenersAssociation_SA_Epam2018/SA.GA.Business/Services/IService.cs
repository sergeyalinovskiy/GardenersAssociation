namespace SA.GA.Business.Services
{
    public interface IService<T>
    {
        void Create(T item);
        void Delete(int id);
        void Update(T item);
    }
}