using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoOrigemReceitum
    {
        public TbGerTipoOrigemReceitum()
        {
            TbDivDiarioArrecadacaos = new HashSet<TbDivDiarioArrecadacao>();
        }

        public short IdTpOrigemReceita { get; set; }
        public string? DsTpOrigemReceita { get; set; }

        public virtual ICollection<TbDivDiarioArrecadacao> TbDivDiarioArrecadacaos { get; set; }
    }
}
