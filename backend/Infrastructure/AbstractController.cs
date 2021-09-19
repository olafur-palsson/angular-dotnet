using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace backend.Infrastructure
{
    public abstract class AbstractController<EntityType, IdType> where EntityType : class
    {
        private IRepository<EntityType, IdType> _repository;
        
        [HttpGet("getOne")]
        public abstract EntityType GetOne(IdType id);
    }
}
