using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspLiquidaco
{
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

    public virtual ICollection<TbDspConsignaco> TbDspConsignacos { get; set; } = new List<TbDspConsignaco>();

    public virtual ICollection<TbDspEstornosLiquidacao> TbDspEstornosLiquidacaos { get; set; } = new List<TbDspEstornosLiquidacao>();

    public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; } = new List<TbDspLiquidacoesDocumento>();

    public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; } = new List<TbDspPagamento>();

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();

    public virtual ICollection<TbDspPagamentosAutorizacao> IdPagamentoAutorizacaos { get; set; } = new List<TbDspPagamentosAutorizacao>();
}
