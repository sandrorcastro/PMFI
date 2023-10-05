using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblLogAcaoTipo
    {
        public NfseTblLogAcaoTipo()
        {
            NfseTblLogAcaos = new HashSet<NfseTblLogAcao>();
        }

        public int Idlogacaotipo { get; set; }
        public string Stnome { get; set; } = null!;

        public virtual ICollection<NfseTblLogAcao> NfseTblLogAcaos { get; set; }
    }
}
