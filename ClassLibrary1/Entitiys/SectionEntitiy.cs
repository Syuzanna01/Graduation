using System.Security.Claims;

namespace DataAccessLayer.Entities
{
    public class SectionEntitiy
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public int ChairsId { get; set; }
        public virtual ChairsEntity Chairs { get; set; }
        public virtual ICollection<GroupEntity> Groups { get; set; }
    }
}
