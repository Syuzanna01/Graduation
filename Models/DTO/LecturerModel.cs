using DataAccessLayer.Helpers;

namespace Gradutation.Models
{
    public class LecturerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public bool IsActive { get; set; }

    }
}
