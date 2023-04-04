using DataAccessLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class GradedModel
    {
        public string IdentityNumber { get; set; }
        public string GroupName { get; set; }
        public int Course { get; set; }
        public string Subject1 { get; set; }
        public int Graded1 { get; set; }
        public string Subject2 { get; set; }
        public int Graded2 { get; set; }
        public string Subject3 { get; set; }
        public int Graded3 { get; set; }
        public string Subject4 { get; set; }
        public int Graded4 { get; set; }
    }
}