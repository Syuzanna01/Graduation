using DataAccessLayer.Entities;
using Graduation.BLL.BLConract;
using Graduation.BLL.Maper;
using Graduation.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.AcaontBL
{

    public class GroupBL : IGroupBL,IStudentBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public GroupBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public GroupEntity GetById(int id)
        {
            return _unitOfWork.GroupRepository.GetById(id);
        }

        public void Insert(StudentsModel student)
        {
            _unitOfWork.StudentRepository.Insert(StudentMaper.MaperStudent(student));
        }
    }
}


