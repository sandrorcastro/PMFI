using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspLiquidaco
    {
        public TbDspLiquidaco()
        {
            TbDspConsignacos = new HashSet<TbDspConsignaco>();
            TbDspEstornosLiquidacaos = new HashSet<TbDspEstornosLiquidacao>();
            TbDspLiquidacoesDocumentos = new HashSet<TbDspLiquidacoesDocumento>();
            TbDspPagamentos = new HashSet<TbDspPagamento>();
            TbSbsPrestacaoConta = new HashSet<TbSbsPrestacaoConta>();
            IdPagamentoAutorizacaos = new HashSet<TbDspPagamentosAutorizacao>();
        }

        public int IdLiquidacao { get; set; }
        public int IdEmpenho { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencia { get; set; }
        public int? NrSequenciaAnual { get; set; }
        public DateTime? DtLiquidacao { get; set; }
        public decimal? VlLiquidacao { get; set; }
        public string? DsHistorico { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdCcgrafica { get; set; }
        public int? IdCcarrecadadora { get; set; }
        public int? IdCcfavorecido { get; set; }
        public int? IdPessoaLiquidante { get; set; }
        public bool? FlCisaoFusao { get; set; }
        public string? NrCpfservidor { get; set; }
        public string? NmServidor { get; set; }
        public int? IdSolicitacao { get; set; }

        public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
        public virtual ICollection<TbDspConsignaco> TbDspConsignacos { get; set; }
        public virtual ICollection<TbDspEstornosLiquidacao> TbDspEstornosLiquidacaos { get; set; }
        public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; }
        public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; }
        public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; }

        public virtual ICollection<TbDspPagamentosAutorizacao> IdPagamentoAutorizacaos { get; set; }
    }
}
