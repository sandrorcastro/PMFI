using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Orgao
{
    public int IdOrgao { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public string? Timbre { get; set; }

    public string SinEnvioProcesso { get; set; } = null!;

    public string? Numeracao { get; set; }

    public string? ServidorCorretorOrtografico { get; set; }

    public string StaCorretorOrtografico { get; set; } = null!;

    public string SinPublicacao { get; set; } = null!;

    public string? CodigoSei { get; set; }

    public string? IdxOrgao { get; set; }

    public int IdContato { get; set; }

    public string SinFederacaoEnvio { get; set; } = null!;

    public string SinFederacaoRecebimento { get; set; } = null!;

    public int? IdUnidade { get; set; }

    public string? IdOrgaoFederacao { get; set; }

    public string SinConsultaProcessual { get; set; } = null!;

    public virtual ICollection<Assinante> Assinantes { get; set; } = new List<Assinante>();

    public virtual ICollection<Cpad> Cpads { get; set; } = new List<Cpad>();

    public virtual ICollection<Feriado> Feriados { get; set; } = new List<Feriado>();

    public virtual Contato IdContatoNavigation { get; set; } = null!;

    public virtual OrgaoFederacao? IdOrgaoFederacaoNavigation { get; set; }

    public virtual Unidade? IdUnidadeNavigation { get; set; }

    public virtual ICollection<Numeracao> Numeracaos { get; set; } = new List<Numeracao>();

    public virtual ICollection<OrdenadorDespesa> OrdenadorDespesas { get; set; } = new List<OrdenadorDespesa>();

    public virtual ICollection<OrgaoHistorico> OrgaoHistoricos { get; set; } = new List<OrgaoHistorico>();

    public virtual ICollection<SeriePublicacao> SeriePublicacaos { get; set; } = new List<SeriePublicacao>();

    public virtual ICollection<SerieRestricao> SerieRestricaos { get; set; } = new List<SerieRestricao>();

    public virtual ICollection<TipoProcedRestricao> TipoProcedRestricaos { get; set; } = new List<TipoProcedRestricao>();

    public virtual ICollection<UnidadeHistorico> UnidadeHistoricos { get; set; } = new List<UnidadeHistorico>();

    public virtual ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<Aviso> IdAvisos { get; set; } = new List<Aviso>();

    public virtual ICollection<ControleInterno> IdControleInternos { get; set; } = new List<ControleInterno>();

    public virtual ICollection<Orgao> IdOrgao1s { get; set; } = new List<Orgao>();

    public virtual ICollection<Orgao> IdOrgao2s { get; set; } = new List<Orgao>();
}
