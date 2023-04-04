using DataAccessLayer.Entities;
using Graduation.DAL;
using Graduation.DAL.Entitiys;
using Graduation.DAL.Repository.Interfaceis;
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
<<<<<<< HEAD
            student.FirstName = obj.FirstName;
            student.LastName = obj.LastName;
            student.Surname = obj.Surname;
            student.Gender = obj.Gender;
            student.Email = obj.Email;
            student.IsActive = obj.IsActive;
            context?.Students.Update(student);
        }
        public void Update1(GradedEntity obj, string IdentityNumber)
        {
            int student = context.Students.FirstOrDefault(u => u.IdentityNumber == IdentityNumber).Id;
            var studentGrad = context?.Gradeds.Find(student);
            
            if (studentGrad is null)
            {
                studentGrad = new GradedEntity();
            }

            studentGrad.StudentId = student;
            studentGrad.Course = obj.Course;
            studentGrad.Subject1 = obj.Subject1;
            studentGrad.Graded1 = obj.Graded1;
            studentGrad.Subject2 = obj.Subject2;
            studentGrad.Graded2 = obj.Graded2;
            studentGrad.Subject3 = obj.Subject3;
            studentGrad.Graded3 = obj.Graded3;
            studentGrad.Subject4 = obj.Subject4;
            studentGrad.Graded4 = obj.Graded4;

            int Credit1 = context.Subjects.FirstOrDefault(t => t.SubjectName==studentGrad.Subject1).Credit;
            int Credit2 = context.Subjects.FirstOrDefault(t => t.SubjectName==studentGrad.Subject2).Credit;
            int Credit3 = context.Subjects.FirstOrDefault(t => t.SubjectName==studentGrad.Subject3).Credit;
            int Credit4 = context.Subjects.FirstOrDefault(t => t.SubjectName==studentGrad.Subject4).Credit;
            if (obj.Graded4 != 0)
            {
                studentGrad.Mog = (studentGrad.Graded1*Credit1 + studentGrad.Graded2*Credit2
                + studentGrad.Graded3* Credit3 + studentGrad.Graded4*Credit4) / 4;
            }
            context?.Gradeds.Update(studentGrad);
=======
            student.FirstName= obj.FirstName;
            student.LastName= obj.LastName;
            student.Surname= obj.Surname;
            student.Gender= obj.Gender;
            student.Email= obj.Email;
            student.IsActive = obj.IsActive;
            context?.Students.Update(student);
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
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