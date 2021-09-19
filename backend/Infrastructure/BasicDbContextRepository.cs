using System.Collections.Generic;
using System.Linq;

namespace backend.Infrastructure
{
    public class BasicDbContextRepository<TEntity> : DbContextRepository<TEntity, string> where TEntity : class
    {
        public override TEntity GetOne(string id)
        {
            return this.Db.Entities.Find(id);
        }

        public override TEntity CreateOne(TEntity entity)
        {
            var created = this.Db.Entities.Add(entity).Entity;
            this.Db.SaveChanges();
            return created;
        }

        public override void DeleteOne(TEntity entity)
        {
            this.Db.Entities.Remove(entity);
            this.Db.SaveChanges();
        }

        public override TEntity UpdateOne(TEntity entity)
        {
            var updated = this.Db.Entities.Update(entity).Entity;
            this.Db.SaveChanges();
            return updated;
        }

        public override List<TEntity> GetAll()
        {
            return (
                from entity in this.Db.Entities
                select entity
            ).ToList();
        }
    }
}