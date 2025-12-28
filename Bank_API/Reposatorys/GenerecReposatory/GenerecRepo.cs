
using Bank_API.DB;
using Microsoft.EntityFrameworkCore;

namespace Bank_API.Reposatorys.GenerecReposatory
{
    public class GenerecRepo<T> : IGenerc<T> where T : class
    {
        protected readonly AppDbContext context;
        private readonly DbSet<T> _dbset;

        public GenerecRepo(AppDbContext context)
        {
            this.context = context;
            _dbset = context.Set<T>();
        }

        public async Task add(T entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task SaveChange()
        {
           await context.SaveChangesAsync();
        }

        public async Task update(T entity)
        {
            _dbset.Update(entity);
        }
    }
}
