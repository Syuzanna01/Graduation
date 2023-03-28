using DataAccessLayer.Entities;
using Graduation.DAL;
using Graduation.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graduation.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected GraduationDBContext context;
        protected DbSet<TEntity> table = null;
        public GenericRepository()
        {
            this.context = new GraduationDBContext();
            table = context.Set<TEntity>();
        }
        public GroupEntity GetStudentName(string GroupName)
        {
            return context?.Groups.FirstOrDefault(u => u.GroupName == GroupName);
        }
        public GroupEntity GetGroupName(int id)
        {
            return context?.Groups.FirstOrDefault(u => u.Id == id);
        }
        public SectionEntitiy GetSectionName(int id)
        {
            return context?.Sections.FirstOrDefault(u => u.Id == id);
        }
        public InstituteEntity GetInstituetNam(int id)
        {
            return context?.Institutes.FirstOrDefault(u => u.Id == id);
        }
        public ChairsEntity GetPulpitNam(int id)
        {
            return context?.Chairs.FirstOrDefault(u => u.Id == id);
        }
        public StudentEntity GetStudentByIdentityNumber(string IdentityNumber)
        {
            var student = context?.Students.FirstOrDefault(u => u.IdentityNumber == IdentityNumber);
            return student;
        }
        public void Remove(string IdentityNumber)
        {
            var student = context?.Students.FirstOrDefault(u => u.IdentityNumber == IdentityNumber);
            student.IsActive = false;
            context?.Students.Update(student);
        }
        public GenericRepository(GraduationDBContext _context)
        {
            this.context = _context;
            table = _context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return table.ToList();
        }
        public TEntity GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(StudentEntity obj)
        {
            context?.Students.Add(obj);
        }
        public void Update(StudentEntity obj)
        {
            var student = context?.Students.FirstOrDefault(u => u.IdentityNumber == obj.IdentityNumber);
            student.FirstName= obj.FirstName;
            student.LastName= obj.LastName;
            student.Surname= obj.Surname;
            student.Gender= obj.Gender;
            student.Email= obj.Email;
            student.IsActive = obj.IsActive;
            context?.Students.Update(student);
        }
        public void Delete(object id)
        {
            //TEntity existing = table.Find(id);
            context.Remove(id);
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}