using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Graduation.BLL.Maper;
using Graduation.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.AccountBL
{
    public class StudentBL:IStudentBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public void Insert(StudentsModel student)
        {


            var aa = StudentMaper.MaperStudent(student);

            aa.GroupId = 3;
            _unitOfWork.StudentRepository.Insert(aa);

            _unitOfWork.StudentRepository.Save();
        }
    }
}
