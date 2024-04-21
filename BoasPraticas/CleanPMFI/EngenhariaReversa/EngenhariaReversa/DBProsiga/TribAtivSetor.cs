using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivSetor
    {
        public TribAtivSetor()
        {
            TribAtivAtividades = new HashSet<TribAtivAtividade>();
            TribAtivSetorTributos = new HashSet<TribAtivSetorTributo>();
        }

        public int AtSetId { get; set; }
        public string AtSetDescricao { get; set; } = null!;

        public virtual ICollection<TribAtivAtividade> TribAtivAtividades { get; set; }
        public virtual ICollection<TribAtivSetorTributo> TribAtivSetorTributos { get; set; }
    }
}
