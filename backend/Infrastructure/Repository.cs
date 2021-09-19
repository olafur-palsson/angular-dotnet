using System.Collections.Generic;

namespace backend.Infrastructure
{
    public interface IRepository<TEntityType, IdType> where TEntityType : class
    {
        TEntityType GetOne(IdType id);
        TEntityType CreateOne(TEntityType entity);
        void DeleteOne(TEntityType entity);
        TEntityType UpdateOne(TEntityType entity);
        List<TEntityType> GetAll();
    }
}