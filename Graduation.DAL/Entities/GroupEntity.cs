namespace DataAccessLayer.Entities
{
    public class GroupEntity
    {
        public int Id { get; set ; }
        public string Group { get; set; }
        public int SectionId { get; set; }
        public virtual ICollection<LecturerGroupEntity> LecturerGroups { get; set; }
        public virtual SectionEntitiy Section { get; set; }
        public virtual ICollection<StudentEntity> Students { get; set; }
    }
}
