using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcDotaco
    {
        public TbOrcDotaco()
        {
            TbCntApostilamentoDotacos = new HashSet<TbCntApostilamentoDotaco>();
            TbCntContratosDotacos = new HashSet<TbCntContratosDotaco>();
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbDspRms = new HashSet<TbDspRm>();
            TbLicDotacos = new HashSet<TbLicDotaco>();
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
            TbOrcAtualizacoesMonetOrcamentoDotacos = new HashSet<TbOrcAtualizacoesMonetOrcamentoDotaco>();
            TbOrcDescentralizacoesCreditosDotacos = new HashSet<TbOrcDescentralizacoesCreditosDotaco>();
            TbOrcDotacoesBloqueiosManuals = new HashSet<TbOrcDotacoesBloqueiosManual>();
            TbOrcDotacoesMovimentacaos = new HashSet<TbOrcDotacoesMovimentacao>();
            TbOrcDotacoesSubAcoesTarefas = new HashSet<TbOrcDotacoesSubAcoesTarefa>();
            TbOrcSolicitacoesSaldoDotacaos = new HashSet<TbOrcSolicitacoesSaldoDotacao>();
            TbOrcSolicitacoesSuplementacaoDotacos = new HashSet<TbOrcSolicitacoesSuplementacaoDotaco>();
        }

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
        public virtual ICollection<TbCntApostilamentoDotaco> TbCntApostilamentoDotacos { get; set; }
        public virtual ICollection<TbCntContratosDotaco> TbCntContratosDotacos { get; set; }
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbDspRm> TbDspRms { get; set; }
        public virtual ICollection<TbLicDotaco> TbLicDotacos { get; set; }
        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
        public virtual ICollection<TbOrcAtualizacoesMonetOrcamentoDotaco> TbOrcAtualizacoesMonetOrcamentoDotacos { get; set; }
        public virtual ICollection<TbOrcDescentralizacoesCreditosDotaco> TbOrcDescentralizacoesCreditosDotacos { get; set; }
        public virtual ICollection<TbOrcDotacoesBloqueiosManual> TbOrcDotacoesBloqueiosManuals { get; set; }
        public virtual ICollection<TbOrcDotacoesMovimentacao> TbOrcDotacoesMovimentacaos { get; set; }
        public virtual ICollection<TbOrcDotacoesSubAcoesTarefa> TbOrcDotacoesSubAcoesTarefas { get; set; }
        public virtual ICollection<TbOrcSolicitacoesSaldoDotacao> TbOrcSolicitacoesSaldoDotacaos { get; set; }
        public virtual ICollection<TbOrcSolicitacoesSuplementacaoDotaco> TbOrcSolicitacoesSuplementacaoDotacos { get; set; }
    }
}
