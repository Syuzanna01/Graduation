namespace DataAccessLayer.Entities
{
    public class ChairsEntity
    {
        public int Id { get; set; } 
        public string Chairs { get; set; }
        public int InstituteId { get; set; }
        public virtual InstituteEntity Institute { get; set; }
        public virtual ICollection<SectionEntitiy> Sections { get; set; }
    }
}
