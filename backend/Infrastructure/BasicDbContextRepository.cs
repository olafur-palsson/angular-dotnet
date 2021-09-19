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
            return this.Db.Entities.Add(entity).Entity;
        }

        public override void DeleteOne(TEntity entity)
        {
            this.Db.Entities.Remove(entity);
        }

        public override TEntity UpdateOne(TEntity entity)
        {
            return this.Db.Entities.Update(entity).Entity;
        }
    }
}