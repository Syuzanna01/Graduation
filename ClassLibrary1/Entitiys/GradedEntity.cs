using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.DAL.Entitiys
{
    public class GradedEntity
    {
        public int Id { get; set; }
        public int Course { get; set; }
        public string Subject1 { get; set; }
        public int Graded1 { get; set; }
        public string Subject2 { get; set; }
        public int Graded2 { get; set; }
        public string Subject3 { get; set; }
        public int Graded3 { get; set; }
        public string Subject4 { get; set; }
        public int Graded4 { get; set; }
        public int Mog { get; set; }
        public int StudentId { get; set; }
        //public int GradedId { get; set; }
        public virtual StudentEntity Student { get; set; }
        //public virtual SubjectEntity Subject { get; set; }
    }
}
