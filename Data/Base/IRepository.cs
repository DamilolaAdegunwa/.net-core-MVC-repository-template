using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GRA.Data.Base
{
    public interface IRepository<T> where T : class, IEntity
    {
        DbSet<T> All { get; }
        DbSet<T> GetAll();
        Task<T> Get(int? id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int? id);
        Task<T> FirstAsync(int? id);
        Task<bool> AnyAsync(int? id);
        
    }
}