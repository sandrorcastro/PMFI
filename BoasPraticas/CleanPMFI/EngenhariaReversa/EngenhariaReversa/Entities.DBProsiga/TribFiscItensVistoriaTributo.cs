using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscItensVistoriaTributo
    {
        public int ItemVistId { get; set; }
        public int TipoTribId { get; set; }
        public decimal? TribItemVistValor { get; set; }
        public short? Idmoeda { get; set; }
        public decimal? TribItemVistValorLimite { get; set; }
        public decimal? TribItemVistValorRef { get; set; }
        public int? TribItemVistAnoRef { get; set; }
        public bool? TribItemVistAtivo { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? TribItemVistGeraUnica { get; set; }
        public decimal? TribItemVistDescontoUnica { get; set; }
        public int? TipoTribIddesconto { get; set; }

        public virtual TribFiscItensVistorium ItemVist { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
