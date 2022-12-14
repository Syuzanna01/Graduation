namespace DataAccessLayer.Entities
{
    public class LecturerGroupEntity
    {
        public int Id { get; set; }
        public int LecturerId { get; set; }
        public int GroupId { get; set; }
        public virtual LecturerEntitiy Lecturer { get; set; }
        public virtual GroupEntity Group { get; set; }
    }
}
