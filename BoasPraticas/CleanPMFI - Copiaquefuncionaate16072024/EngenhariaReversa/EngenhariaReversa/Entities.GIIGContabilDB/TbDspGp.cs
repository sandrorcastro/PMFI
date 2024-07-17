using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspGp
    {
        public int IdGps { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? CdPagamento { get; set; }
        public int? IdPessoa { get; set; }
        public short? NrMesComp { get; set; }
        public decimal? VlGps { get; set; }
        public decimal? VlOutros { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlDescontos { get; set; }
        public DateTime? DtRemessa { get; set; }
        public int? NrRemessa { get; set; }
        public int? NrSeqRemessa { get; set; }
        public string? StGps { get; set; }
        public int? IdCc { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtVencimento { get; set; }
        public string? DsObservacao { get; set; }
        public int? NrSeq { get; set; }
        public string? DsGuia { get; set; }
        public int? IdConsignacao { get; set; }
        public int? IdEmpenho { get; set; }
        public int? IdLiquidacao { get; set; }
        public string? CdOcorrencia { get; set; }
        public int? IdDespesaRepasse { get; set; }
        public int? IdDetalheOrdemCredito { get; set; }

        public virtual TbDspCodigosPagamentoInss? CdPagamentoNavigation { get; set; }
        public virtual TbDspConsignaco? IdConsignacaoNavigation { get; set; }
        public virtual TbDspEmpenho? IdEmpenhoNavigation { get; set; }
    }
}
