using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspConsignaco
    {
        public TbDspConsignaco()
        {
            TbDspConsignacoesItens = new HashSet<TbDspConsignacoesIten>();
            TbDspGps = new HashSet<TbDspGp>();
            TbDspLiquidacoesDoctosIntegrados = new HashSet<TbDspLiquidacoesDoctosIntegrado>();
            TbDspPagamentos = new HashSet<TbDspPagamento>();
            IdDespesas = new HashSet<TbDspDespesaExtraOrcamentarium>();
        }

        public int IdConsignacao { get; set; }
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

        public virtual TbDspLiquidaco? IdLiquidacaoNavigation { get; set; }
        public virtual TbCapRecurso? IdRecursoNavigation { get; set; }
        public virtual TbDspTiposConsignaco? IdTipoConsignacaoNavigation { get; set; }
        public virtual ICollection<TbDspConsignacoesIten> TbDspConsignacoesItens { get; set; }
        public virtual ICollection<TbDspGp> TbDspGps { get; set; }
        public virtual ICollection<TbDspLiquidacoesDoctosIntegrado> TbDspLiquidacoesDoctosIntegrados { get; set; }
        public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; }

        public virtual ICollection<TbDspDespesaExtraOrcamentarium> IdDespesas { get; set; }
    }
}
