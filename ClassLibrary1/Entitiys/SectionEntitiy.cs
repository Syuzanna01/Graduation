namespace DataAccessLayer.Entities
{
    public class SectionEntitiy
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public int InstituetId { get; set; }
        public virtual InstituteEntity Institute { get; set; }
        //public virtual LecturerEntitiy Lecturer { get; set; }--
        public virtual ICollection<GroupEntity> Groups { get; set; }
    }
}
