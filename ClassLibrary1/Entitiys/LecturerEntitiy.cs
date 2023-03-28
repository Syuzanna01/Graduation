using DataAccessLayer.Helpers;

namespace DataAccessLayer.Entities
{
    public class LecturerEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<LecturerGroupEntity> LecturerGroups { get; set; }
    }
}
