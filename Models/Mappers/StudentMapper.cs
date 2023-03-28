using DataAccessLayer.Entities;
using Gradutation.Models;
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
                IsActive= students.IsActive,    
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
    }
}
