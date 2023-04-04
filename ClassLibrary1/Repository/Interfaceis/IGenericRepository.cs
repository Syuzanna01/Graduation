using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduation.DAL.Repository.Interfaceis
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity obj);
        void Update(StudentEntity obj);
        void Delete(object id);
        void Save();
    }
}
