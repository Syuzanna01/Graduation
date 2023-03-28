using DataAccessLayer.Entities;
using Gradutation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.BLConract
{
    public interface IStudentBL
    {
        //StudentEntity GetById(string id);
        StudentModel GetByIdentityNumber(string IdentityNumber);
        void Remove(string IdentityNumber);
        void Insert(StudentModel student);
        void Update(StudentModel student);
    }
}
