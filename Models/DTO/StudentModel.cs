
using DataAccessLayer.Helpers;

namespace Gradutation.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string GroupName { get; set; }
        public string Section { get; set; }
        public string Chairs { get; set; }
        public string Institute { get; set; }
        public int Semester1 { get; set; }
        public int Semester2 { get; set; }
        public int Semester3 { get; set; }
        public int Semester4 { get; set; }
        public int Semester5 { get; set; }
        public int Semester6 { get; set; }
        public int Semester7 { get; set; }
        public int Semester8 { get; set; }
    }
}
