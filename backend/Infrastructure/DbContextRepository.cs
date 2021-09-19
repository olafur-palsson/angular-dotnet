using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure
{
    public abstract class DbContextRepository<TEntity, IdType> : IRepository<TEntity, IdType> where TEntity : class
    {
        protected class Context : DbContext
        {
            public DbSet<TEntity> Entities { get; set; }
        }

        protected readonly Context Db = new Context();
        
        public abstract TEntity GetOne(IdType id);
        public abstract TEntity CreateOne(TEntity entity);
        public abstract void DeleteOne(TEntity entityType);
        public abstract TEntity UpdateOne(TEntity entity);
        public abstract List<TEntity> GetAll();
    }
}