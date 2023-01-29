using DataAccessLayer.Entities;
using Graduation.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.BLConract
{
    public interface IGroupBL
    {
        GroupEntity GetById(int id);
    }
    public interface IStudentBL
    {
        void Insert(StudentsModel student);
    }

}
