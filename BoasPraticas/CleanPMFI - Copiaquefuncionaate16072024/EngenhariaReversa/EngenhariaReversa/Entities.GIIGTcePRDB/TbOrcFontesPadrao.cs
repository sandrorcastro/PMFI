using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcFontesPadrao
    {
        public TbOrcFontesPadrao()
        {
            TbOrcFontesCorrelacaoOrigens = new HashSet<TbOrcFontesCorrelacaoOrigen>();
        }

        public short NrAno { get; set; }
        public string CdFonte { get; set; } = null!;
        public string? DsFontePadrao { get; set; }
        public string? FlPermiteDesdobra { get; set; }

        public virtual ICollection<TbOrcFontesCorrelacaoOrigen> TbOrcFontesCorrelacaoOrigens { get; set; }
    }
}
