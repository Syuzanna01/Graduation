using DataAccessLayer.Helpers;

namespace DataAccessLayer.Entities
{
    public class LecturerEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public int Departmenthead { get; set; }
        public int Boss { get; set; }
        public string Position { get; set; }
        public virtual ICollection<LecturerGroupEntity> LecturerGroups { get; set; }
        public virtual SectionEntitiy Section { get; set; }
    }
}
