using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmptbDspConsignacoesCmfi
    {
        public int? IdConsignacao { get; set; }
        public short? NrSequencia { get; set; }
        public int? IdLiquidacao { get; set; }
        public DateTime? DtConsignacao { get; set; }
        public int? IdPessoa { get; set; }
        public string? NrCei { get; set; }
        public decimal? VlConsignacao { get; set; }
        public int? IdContaContabil { get; set; }
        public int? IdContaContabilInscricao { get; set; }
        public string? DsHistorico { get; set; }
        public decimal? NrPercentual { get; set; }
        public int? IdRecurso { get; set; }
        public short? IdTipoConsignacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? FlExcluido { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdLiquidacaoDocto { get; set; }
        public short? IdTipoDocFinanceiro { get; set; }
        public string? NrDocumento { get; set; }
        public int? IdCcorigem { get; set; }
        public int? Idempenho { get; set; }
        public int? IdConsignaPmfi { get; set; }
        public int? ChaveExtra { get; set; }
    }
}
