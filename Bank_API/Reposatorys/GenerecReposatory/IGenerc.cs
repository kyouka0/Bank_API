namespace Bank_API.Reposatorys.GenerecReposatory
{
    public interface IGenerc<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task add(T entity);
        Task update(T entity);
        Task delete(T entity);
        Task SaveChange();
    }
}
