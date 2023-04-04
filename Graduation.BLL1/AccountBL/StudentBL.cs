using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Graduation.DAL.UnitOfWork;
using Gradutation.Models;
<<<<<<< HEAD
using Models.DTO;
=======
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
using Models.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.AccountBL
{
    public class StudentBL : IStudentBL
    {
        private readonly IUnitOfWork unitOfWork;

        public StudentBL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public void Insert(StudentModel student)
        {
            // StudentEntity studentEntity = Mapper<StudentModel, StudentEntity>.Map(student);

            var studentEntity = StudentMaper.MaperStudent(student);
            var groupId = unitOfWork.StudentRepository.GetStudentName(student.GroupName);
            studentEntity.GroupId = groupId.Id;

            unitOfWork.StudentRepository.Insert(studentEntity);

            unitOfWork.StudentRepository.Save();
        }
        public void Update(StudentModel student)
        {
            var studentEntity = StudentMaper.MaperStudent(student);
            var groupId = unitOfWork.StudentRepository.GetStudentName(student.GroupName);
            studentEntity.GroupId = groupId.Id;

            unitOfWork.StudentRepository.Update(studentEntity);

            unitOfWork.StudentRepository.Save();
        }

<<<<<<< HEAD
        public void Update1(GradedModel student)
        {
            var studentEntity = StudentMaper.MaperGraded(student);
            
            unitOfWork.StudentRepository.Update1(studentEntity,student.IdentityNumber);

            unitOfWork.StudentRepository.Save();
        }
=======
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
        //public StudentEntity GetById(string id)
        //{
        //    return unitOfWork.StudentRepository.GetById(id);
        //}
        public StudentModel GetByIdentityNumber(string IdentityNumber)
        {
            var student = unitOfWork.StudentRepository.GetStudentByIdentityNumber(IdentityNumber);
            var group = unitOfWork.GroupRepository.GetGroupName(student.GroupId);
            var section = unitOfWork.SectionRepository.GetSectionName(group.SectionId);
            var chairs = unitOfWork.PulpitRepository.GetPulpitNam(section.ChairsId);

            var institute = unitOfWork.InstituteRepository.GetInstituetNam(chairs.InstituteId);

            var studentModel = new StudentModel()
            {
                LastName = student.LastName,
                FirstName = student.FirstName,
                Surname = student.Surname,
                IdentityNumber = student.IdentityNumber,
                Email = student.Email,
                GroupName = group.GroupName,
                Section= section.Section,
                Chairs = chairs.Chairs,
                Institute = institute.Institute
            };
            return studentModel;
        }

        public void Remove(string IdentityNumber)
        {
            unitOfWork.StudentRepository.Remove(IdentityNumber);
            unitOfWork.StudentRepository.Save();
        }
    }
}
