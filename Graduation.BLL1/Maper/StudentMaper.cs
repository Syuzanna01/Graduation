using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.Maper
{
    public static class StudentMaper
    {
        public static StudentEntity MaperStudent(StudentsModel students)
        {

            return new StudentEntity()
            {
                Name = students.Name,
                Surname = students.Surname,
                Patronymic = students.Patronymic,
                Gender = students.Gender,
                IdentityNumber = students.IdentityNumber,
                Email = students.Email,
                Sr = students.Sr,
                GroupId = students.GroupId
            };
        }
    }
}
