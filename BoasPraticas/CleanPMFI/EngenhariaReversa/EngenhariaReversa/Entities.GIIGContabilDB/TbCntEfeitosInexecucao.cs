using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntEfeitosInexecucao
    {
        public int IdEfeitoInexecucao { get; set; }
        public int IdContrato { get; set; }
        public string? FlInexecContratante { get; set; }
        public string? DsTipoEfeito { get; set; }
        public string? DsTipoPenalidade { get; set; }
        public DateTime? DtTermo { get; set; }
        public DateTime? DtPublicacaoTermo { get; set; }
        public decimal? VlEfeito { get; set; }
        public string? DsMotivo { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;
    }
}
