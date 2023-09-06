using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceita
    {
        public TbOrcReceita()
        {
            InverseIdReceitaNivelSuperNavigation = new HashSet<TbOrcReceita>();
            TbDspDespesaExtraOrcamentariaDevReceita = new HashSet<TbDspDespesaExtraOrcamentariaDevReceita>();
            TbOrcReceitasFontes = new HashSet<TbOrcReceitasFonte>();
            TbOrcReceitasFontesOperacaos = new HashSet<TbOrcReceitasFontesOperacao>();
            TbOrcReceitasOrcamentoAnuals = new HashSet<TbOrcReceitasOrcamentoAnual>();
            TbOrcReceitasReestimada = new HashSet<TbOrcReceitasReestimada>();
            TbPlaProjecoesReceita = new HashSet<TbPlaProjecoesReceita>();
            TbPpaProjecoesReceita = new HashSet<TbPpaProjecoesReceita>();
            TbRecMovimentoReceitasDetalhes = new HashSet<TbRecMovimentoReceitasDetalhe>();
            TbSbsPrestacaoConta = new HashSet<TbSbsPrestacaoConta>();
        }

        public int IdReceita { get; set; }
        public short? IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public string? CdReceita { get; set; }
        public string? DsReceita { get; set; }
        public string? DsEspecificacao { get; set; }
        public string? FlReceitaPadrao { get; set; }
        public string? DsTipoReceitaPadrao { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public int? IdReceitaNivelSuper { get; set; }
        public string? FlReceitaIntraOrcamentaria { get; set; }
        public short? IdTipoPermissaoDeducao { get; set; }
        public short? IdTipoNivelContaNumerico { get; set; }
        public short? IdTipoEsferaGoverno { get; set; }
        public string? Observacao { get; set; }

        public virtual TbOrcReceita? IdReceitaNivelSuperNavigation { get; set; }
        public virtual ICollection<TbOrcReceita> InverseIdReceitaNivelSuperNavigation { get; set; }
        public virtual ICollection<TbDspDespesaExtraOrcamentariaDevReceita> TbDspDespesaExtraOrcamentariaDevReceita { get; set; }
        public virtual ICollection<TbOrcReceitasFonte> TbOrcReceitasFontes { get; set; }
        public virtual ICollection<TbOrcReceitasFontesOperacao> TbOrcReceitasFontesOperacaos { get; set; }
        public virtual ICollection<TbOrcReceitasOrcamentoAnual> TbOrcReceitasOrcamentoAnuals { get; set; }
        public virtual ICollection<TbOrcReceitasReestimada> TbOrcReceitasReestimada { get; set; }
        public virtual ICollection<TbPlaProjecoesReceita> TbPlaProjecoesReceita { get; set; }
        public virtual ICollection<TbPpaProjecoesReceita> TbPpaProjecoesReceita { get; set; }
        public virtual ICollection<TbRecMovimentoReceitasDetalhe> TbRecMovimentoReceitasDetalhes { get; set; }
        public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; }
    }
}
