﻿using DataAccessLayer.Entities;
<<<<<<< HEAD
using Graduation.DAL.Entitiys;
using Gradutation.Models;
using Models.DTO;
=======
using Gradutation.Models;
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
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
<<<<<<< HEAD
                IsActive = students.IsActive,
=======
                IsActive= students.IsActive,    
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
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
<<<<<<< HEAD

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
=======
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
            };
        }
    }
}
