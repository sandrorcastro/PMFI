using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Unidade
    {
        public Unidade()
        {
            Divisos = new HashSet<Diviso>();
        }

        public int UniId { get; set; }
        public string? UniNome { get; set; }
        public int? UniOrgaoId { get; set; }
        public string? UniExtincao { get; set; }
        public DateTime? UniDtExtincao { get; set; }

        public virtual Orgao? UniOrgao { get; set; }
        public virtual ICollection<Diviso> Divisos { get; set; }
    }
}
