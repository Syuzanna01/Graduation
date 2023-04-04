using DataAccessLayer.Entities;
using Gradutation.Models;
<<<<<<< HEAD
using Models.DTO;
=======
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.BLConract
{
    public interface IStudentBL
    {
<<<<<<< HEAD
=======
        //StudentEntity GetById(string id);
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
        StudentModel GetByIdentityNumber(string IdentityNumber);
        void Remove(string IdentityNumber);
        void Insert(StudentModel student);
        void Update(StudentModel student);
<<<<<<< HEAD
        void Update1(GradedModel student);
=======
>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f
    }
}
