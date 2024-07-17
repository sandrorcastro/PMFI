using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TipoConcessao
    {
        public TipoConcessao()
        {
            ContratoConcessaos = new HashSet<ContratoConcessao>();
        }

        public int IdTipoConcessao { get; set; }
        public string TipoConcessao1 { get; set; } = null!;

        public virtual ICollection<ContratoConcessao> ContratoConcessaos { get; set; }
    }
}
