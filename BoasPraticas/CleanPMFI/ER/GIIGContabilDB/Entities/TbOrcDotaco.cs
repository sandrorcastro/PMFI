using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcDotaco
{
    public int Iddotacao { get; set; }

    public int IdAcao { get; set; }

    public int IdNatDespesa { get; set; }

    public int IdFonte { get; set; }

    public decimal? VlOrcado { get; set; }

    public string? DsTipoCredito { get; set; }

    public decimal? VlDisponivel { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? IdRecurso { get; set; }

    public string? DsTipoOrcamento { get; set; }

    public short? IdTipoCreditoInicial { get; set; }

    public virtual TbOrcProgramasAco IdAcaoNavigation { get; set; } = null!;

    public virtual TbOrcFonte IdFonteNavigation { get; set; } = null!;

    public virtual TbOrcNaturezasDespesa IdNatDespesaNavigation { get; set; } = null!;

    public virtual TbOrcTipoCreditoInicial? IdTipoCreditoInicialNavigation { get; set; }

    public virtual ICollection<TbCntApostilamentoDotaco> TbCntApostilamentoDotacos { get; set; } = new List<TbCntApostilamentoDotaco>();

    public virtual ICollection<TbCntContratosDotaco> TbCntContratosDotacos { get; set; } = new List<TbCntContratosDotaco>();

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbDspRm> TbDspRms { get; set; } = new List<TbDspRm>();

    public virtual ICollection<TbLicDotaco> TbLicDotacos { get; set; } = new List<TbLicDotaco>();

    public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; } = new List<TbOrcAlteracoesOrcamentaria>();

    public virtual ICollection<TbOrcAtualizacoesMonetOrcamentoDotaco> TbOrcAtualizacoesMonetOrcamentoDotacos { get; set; } = new List<TbOrcAtualizacoesMonetOrcamentoDotaco>();

    public virtual ICollection<TbOrcDescentralizacoesCreditosDotaco> TbOrcDescentralizacoesCreditosDotacos { get; set; } = new List<TbOrcDescentralizacoesCreditosDotaco>();

    public virtual ICollection<TbOrcDotacoesBloqueiosManual> TbOrcDotacoesBloqueiosManuals { get; set; } = new List<TbOrcDotacoesBloqueiosManual>();

    public virtual ICollection<TbOrcDotacoesMovimentacao> TbOrcDotacoesMovimentacaos { get; set; } = new List<TbOrcDotacoesMovimentacao>();

    public virtual ICollection<TbOrcDotacoesSubAcoesTarefa> TbOrcDotacoesSubAcoesTarefas { get; set; } = new List<TbOrcDotacoesSubAcoesTarefa>();

    public virtual ICollection<TbOrcSolicitacoesSaldoDotacao> TbOrcSolicitacoesSaldoDotacaos { get; set; } = new List<TbOrcSolicitacoesSaldoDotacao>();

    public virtual ICollection<TbOrcSolicitacoesSuplementacaoDotaco> TbOrcSolicitacoesSuplementacaoDotacos { get; set; } = new List<TbOrcSolicitacoesSuplementacaoDotaco>();
}
