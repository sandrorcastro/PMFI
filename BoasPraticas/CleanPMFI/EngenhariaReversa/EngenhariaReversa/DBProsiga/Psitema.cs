using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Psitema
    {
        public Psitema()
        {
            Psiformularios = new HashSet<Psiformulario>();
        }

        public long TemaId { get; set; }
        public long? TemaCabecObjId { get; set; }
        public long? TemaRodapeobjId { get; set; }
        public string? TemaTitulo { get; set; }

        public virtual Psiobjeto? TemaCabecObj { get; set; }
        public virtual Psiobjeto? TemaRodapeobj { get; set; }
        public virtual ICollection<Psiformulario> Psiformularios { get; set; }
    }
}
