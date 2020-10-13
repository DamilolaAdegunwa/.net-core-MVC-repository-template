using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GRA.Data.Base;
using GRA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GRA.Data
{
    public class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseModel, IEntity
        where TContext : ApplicationDbContext
    {
        private readonly TContext context;

        private readonly IHttpContextAccessor accessor;
        private readonly UserManager<User> userManager;

        public DbSet<TEntity> All => GetAll();

        public EfCoreRepository(TContext context, IHttpContextAccessor accessor, UserManager<User> userManager)
        {
            this.context = context;
            this.accessor = accessor;
            this.userManager = userManager;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int? id)
        {
            if (id == null) return null;

            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            entity.IsActive = false;
            await SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int? id)
        {
            return id == null ? null : await context.Set<TEntity>().FindAsync(id);
        }

        public Task<TEntity> FirstAsync(int? id)
        {
            return id == null ? null : context.Set<TEntity>().FirstOrDefaultAsync(x=>x.Id == id);
        }

        public Task<bool> AnyAsync(int? id)
        {
            return context.Set<TEntity>().AnyAsync(x=>x.Id == id);
        }

        public DbSet<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
            return entity;
        }


        private async Task<int> SaveChangesAsync()
        {
            
            return await context.SaveChangesAsync(GetUserId());
        }

        private string GetUserId()
        {
            return userManager.GetUserId(accessor?.HttpContext?.User);
        }

       
    }
}