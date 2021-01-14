using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCart.Data.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id); 
        IQueryable<TEntity> GetAll(); 
    }
}
