using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceita
{
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

    public virtual ICollection<TbOrcReceita> InverseIdReceitaNivelSuperNavigation { get; set; } = new List<TbOrcReceita>();

    public virtual ICollection<TbDspDespesaExtraOrcamentariaDevReceita> TbDspDespesaExtraOrcamentariaDevReceita { get; set; } = new List<TbDspDespesaExtraOrcamentariaDevReceita>();

    public virtual ICollection<TbOrcReceitasFonte> TbOrcReceitasFontes { get; set; } = new List<TbOrcReceitasFonte>();

    public virtual ICollection<TbOrcReceitasFontesOperacao> TbOrcReceitasFontesOperacaos { get; set; } = new List<TbOrcReceitasFontesOperacao>();

    public virtual ICollection<TbOrcReceitasOrcamentoAnual> TbOrcReceitasOrcamentoAnuals { get; set; } = new List<TbOrcReceitasOrcamentoAnual>();

    public virtual ICollection<TbOrcReceitasReestimada> TbOrcReceitasReestimada { get; set; } = new List<TbOrcReceitasReestimada>();

    public virtual ICollection<TbPlaProjecoesReceita> TbPlaProjecoesReceita { get; set; } = new List<TbPlaProjecoesReceita>();

    public virtual ICollection<TbPpaProjecoesReceita> TbPpaProjecoesReceita { get; set; } = new List<TbPpaProjecoesReceita>();

    public virtual ICollection<TbRecMovimentoReceitasDetalhe> TbRecMovimentoReceitasDetalhes { get; set; } = new List<TbRecMovimentoReceitasDetalhe>();

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();
}
