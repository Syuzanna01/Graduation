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
<<<<<<< HEAD:ClassLibrary1/Repository/Interfaceis/IGenericRepository.cs
        void Insert(TEntity obj);
=======
        void Insert(StudentEntity obj);
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Repository/IGenericRepository.cs
        void Update(StudentEntity obj);
        void Delete(object id);
        void Save();
    }
}
