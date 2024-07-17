using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoArrecadacao
    {
        public TbGerTipoArrecadacao()
        {
            TbDivDiarioArrecadacaos = new HashSet<TbDivDiarioArrecadacao>();
        }

        public short IdTpArrecadacao { get; set; }
        public string? DsTpArrecadacao { get; set; }

        public virtual ICollection<TbDivDiarioArrecadacao> TbDivDiarioArrecadacaos { get; set; }
    }
}
