using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAtivAtividade
{
    public string Atividade { get; set; } = null!;

    public string? AtividadeDenom { get; set; }

    public string? AtivClasse { get; set; }

    public string? AtividadeAutonomo { get; set; }

    public string? AtividadeCodAntigo { get; set; }

    /// <summary>
    /// informa se esta atividade deve ou não ser enquadrada como micro empresa
    /// </summary>
    public string? AtividadeEnquadrMicroEmpr { get; set; }

    /// <summary>
    /// Este campo foi criado pois existe no SMTR. (michimi)
    /// </summary>
    public decimal? AtividadeUffiacresc { get; set; }

    public int? AtSetId { get; set; }

    /// <summary>
    /// Marca se a atividade é padrão da tabela CNAE.
    /// </summary>
    public string? AtCnae { get; set; }

    /// <summary>
    /// Explicar os requisitos necessários para abertura de um empresa com a atividade.
    /// </summary>
    public string? AtRequisitos { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? AtivVedadaSimplesNacional { get; set; }

    public string? AtividadeRisco { get; set; }

    public virtual TribAtivSetor? AtSet { get; set; }

    public virtual TribAtivClasse? AtivClasseNavigation { get; set; }

    public virtual ICollection<FissAtividadesDocto> FissAtividadesDoctos { get; set; } = new List<FissAtividadesDocto>();

    public virtual ICollection<SerIturEmpresasSemCmcativ> SerIturEmpresasSemCmcativs { get; set; } = new List<SerIturEmpresasSemCmcativ>();

    public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; } = new List<Tbconsultapreviadocumentoresposta>();

    public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; } = new List<Tbconsultapreviagrauriscoresposta>();

    public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; } = new List<Tbconsultapreviagraurisco>();

    public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; } = new List<Tbconsultapreviazoneamentoresposta>();

    public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; } = new List<TbtribZonaZoneamentoAtividadePergunta>();

    public virtual ICollection<TribAtivAtividadeDocumento> TribAtivAtividadeDocumentos { get; set; } = new List<TribAtivAtividadeDocumento>();

    public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; } = new List<TribAtivAtividadeGrauRiscoPergunta>();

    public virtual ICollection<TribAtivAtividadeGrauRisco> TribAtivAtividadeGrauRiscos { get; set; } = new List<TribAtivAtividadeGrauRisco>();

    public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; } = new List<TribAtivTributosEmpresa>();

    public virtual ICollection<TribAtividadeTipoAlvaraTributo> TribAtividadeTipoAlvaraTributos { get; set; } = new List<TribAtividadeTipoAlvaraTributo>();

    public virtual ICollection<TribEmpresasAtiv> TribEmpresasAtivs { get; set; } = new List<TribEmpresasAtiv>();

    public virtual ICollection<TribZonaZoneamentoAtividade> TribZonaZoneamentoAtividades { get; set; } = new List<TribZonaZoneamentoAtividade>();

    public virtual ICollection<TribTiposServico> Servs { get; set; } = new List<TribTiposServico>();
}
