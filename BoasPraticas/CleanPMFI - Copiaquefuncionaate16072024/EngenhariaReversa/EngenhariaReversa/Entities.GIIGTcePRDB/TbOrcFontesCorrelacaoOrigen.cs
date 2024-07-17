using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbOrcFontesCorrelacaoOrigen
    {
        public TbOrcFontesCorrelacaoOrigen()
        {
            TbOrcFontesGiiGcorrelacaos = new HashSet<TbOrcFontesGiiGcorrelacao>();
        }

        public int IdCorrelacao { get; set; }
        public short NrAno { get; set; }
        public string CdFonte { get; set; } = null!;
        public string CdOrigem { get; set; } = null!;
        public string CdAplicacao { get; set; } = null!;
        public string CdDesdobramento { get; set; } = null!;
        public string CdDetalhamento { get; set; } = null!;

        public virtual TbOrcAplicacaoRecurso CdAplicacaoNavigation { get; set; } = null!;
        public virtual TbOrcDesdobramentoFonte CdDesdobramentoNavigation { get; set; } = null!;
        public virtual TbOrcDetalhamentoFonte CdDetalhamentoNavigation { get; set; } = null!;
        public virtual TbOrcOrigemRecurso CdOrigemNavigation { get; set; } = null!;
        public virtual TbOrcFontesPadrao TbOrcFontesPadrao { get; set; } = null!;
        public virtual ICollection<TbOrcFontesGiiGcorrelacao> TbOrcFontesGiiGcorrelacaos { get; set; }
    }
}
