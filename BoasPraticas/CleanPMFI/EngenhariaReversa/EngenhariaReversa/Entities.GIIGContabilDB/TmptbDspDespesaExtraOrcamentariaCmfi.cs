using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmptbDspDespesaExtraOrcamentariaCmfi
    {
        public int? IdDespesa { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtDespesa { get; set; }
        public short? NrSequencia { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdFonte { get; set; }
        public int? IdRecurso { get; set; }
        public int? IdContaContabilDebito { get; set; }
        public int? IdContaContabilCredito { get; set; }
        public decimal? VlDespesa { get; set; }
        public string? DsHistorico { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public short? IdTipoDocFinanceiro { get; set; }
        public string? NrDocFinanceiro { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? DsTipo { get; set; }
        public int? IdCcfavorecido { get; set; }
        public int? IdEmpenho { get; set; }
        public short? IdEmpresaOrigem { get; set; }
        public short? IdGrupo { get; set; }
        public short? IdConsignacaoOrigem { get; set; }
        public short? IdDespesaDestino { get; set; }
    }
}
