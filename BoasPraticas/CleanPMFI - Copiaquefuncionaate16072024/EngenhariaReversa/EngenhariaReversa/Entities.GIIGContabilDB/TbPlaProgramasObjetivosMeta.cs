using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaProgramasObjetivosMeta
    {
        public int IdObjetivoMeta { get; set; }
        public int? IdVersaoCriacao { get; set; }
        public string? CdObjetivoMeta { get; set; }
        public string? DsObjetivoMeta { get; set; }
        public decimal? NrMudancaIndice { get; set; }
        public int IdIndicador { get; set; }
        public int IdPublicoAlvo { get; set; }
        public int? IdPrograma { get; set; }
        public int? IdObjetivo { get; set; }

        public virtual TbPlaIndicadore IdIndicadorNavigation { get; set; } = null!;
        public virtual TbPlaPublicosAlvo IdPublicoAlvoNavigation { get; set; } = null!;
    }
}
