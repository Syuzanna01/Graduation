using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class InstituteEntity
    {
        public int Id { get; set; }
        public string Institute { get; set; }
        public int PulpitId { get; set; }
        public virtual ICollection<SectionEntitiy> Sections { get; set; }
        public virtual PulpitEntity Pulpit { get; set; }
    }
}
