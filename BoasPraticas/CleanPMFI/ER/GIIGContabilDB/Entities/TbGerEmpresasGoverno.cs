using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerEmpresasGoverno
{
    public short Idempresa { get; set; }

    public string? DsTipoAdm { get; set; }

    /// <summary>
    /// Se é Prefeitura/Câmara/Autarquia/Previência
    /// </summary>
    public string? DsTipoEmpresa { get; set; }

    public string? NrCnpj { get; set; }

    public string? NmRazaoSocial { get; set; }

    public byte[]? ImLogo { get; set; }

    public int? CdTce { get; set; }

    public int? Idendereco { get; set; }

    public int? NrPredial { get; set; }

    public string? DsComplEndereco { get; set; }

    public string? DsEmail { get; set; }

    public string? DsSite { get; set; }

    public string? DsNomeLogo { get; set; }

    public string? DsExtensaoLogo { get; set; }

    public string? FlCamaraCentralizada { get; set; }

    public int? NrHabitantes { get; set; }

    public byte[]? ImMarcaDagua { get; set; }

    public string? DsFone { get; set; }

    public string? NrFax { get; set; }

    public string? DsSigla { get; set; }

    public string? CdIbge { get; set; }

    public virtual TbGerEndereco? IdenderecoNavigation { get; set; }

    public virtual ICollection<TbDspEstornosEmpenho> TbDspEstornosEmpenhos { get; set; } = new List<TbDspEstornosEmpenho>();

    public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; } = new List<TbFinContasContabeisLancamentosAnalisador>();

    public virtual ICollection<TbGerCargosServidore> TbGerCargosServidores { get; set; } = new List<TbGerCargosServidore>();

    public virtual ICollection<TbGerEmpresasGovAnosContabil> TbGerEmpresasGovAnosContabils { get; set; } = new List<TbGerEmpresasGovAnosContabil>();

    public virtual ICollection<TbLdoLimitesAnual> TbLdoLimitesAnuals { get; set; } = new List<TbLdoLimitesAnual>();

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();

    public virtual ICollection<TbOrcAtualizacoesMonetariaOrcamento> TbOrcAtualizacoesMonetariaOrcamentos { get; set; } = new List<TbOrcAtualizacoesMonetariaOrcamento>();

    public virtual ICollection<TbOrcOrgao> TbOrcOrgaos { get; set; } = new List<TbOrcOrgao>();

    public virtual ICollection<TbOrcPrograma> TbOrcProgramas { get; set; } = new List<TbOrcPrograma>();

    public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; } = new List<TbRecMovimentoReceita>();
}
