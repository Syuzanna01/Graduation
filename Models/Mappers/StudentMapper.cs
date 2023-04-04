using DataAccessLayer.Entities;
using Graduation.DAL.Entitiys;
using Gradutation.Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Mappers
{
    public static class StudentMaper
    {
        public static StudentEntity MaperStudent(StudentModel students)
        {

            return new StudentEntity()
            {
                LastName = students.LastName,
                FirstName = students.FirstName,
                Surname = students.Surname,
                Gender = students.Gender,
                IdentityNumber = students.IdentityNumber,
                Email = students.Email,
                IsActive = students.IsActive,
                Group = new GroupEntity()
                {
                    GroupName = students.GroupName,
                    Section = new SectionEntitiy()
                    {
                        Section = students.Section,
                        Chairs = new ChairsEntity()
                        {
                            Chairs = students.Chairs,
                            Institute = new InstituteEntity()
                            {
                                Institute = students.Institute,
                            }
                        }
                    }
                }

            };
        }
        public static GradedEntity MaperGraded(GradedModel students)
        {

            return new GradedEntity()
            {
                Course = students.Course,
                Subject1 = students.Subject1,
                Subject2 = students.Subject2,
                Subject3 = students.Subject3,
                Subject4 = students.Subject4,
                Graded1 = students.Graded1,
                Graded2 = students.Graded2,
                Graded3 = students.Graded3,
                Graded4 = students.Graded4,
                Student = new StudentEntity()
                {
                    IdentityNumber = students.IdentityNumber,
                    Group = new GroupEntity()
                    {
                        GroupName = students.GroupName,
                    }
                }
            };
        }
    }
}
