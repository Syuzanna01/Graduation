using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.BLL.BLConract
{
    public interface IStudentBL
    {
        void Insert(StudentsModel student);
    }
}
