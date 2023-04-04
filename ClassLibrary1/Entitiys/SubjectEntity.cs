using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.DAL.Entitiys
{
    public class SubjectEntity
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Credit { get; set; }
        //public virtual ICollection<GradedEntity> Gradeds { get; set; }
    }
}
