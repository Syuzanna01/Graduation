namespace DataAccessLayer.Entities
{
    public class PulpitEntity
    {
        public int Id { get; set; } 
        public string Pulpit { get; set; }
        public virtual ICollection<InstituteEntity> Institutes { get; set; }
    }
}
