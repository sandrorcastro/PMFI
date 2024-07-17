using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InstalacaoFederacao
{
    public string IdInstalacaoFederacao { get; set; } = null!;

    public long Cnpj { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Endereco { get; set; } = null!;

    public string? ChavePublicaLocal { get; set; }

    public string? ChavePublicaRemota { get; set; }

    public string? ChavePrivada { get; set; }

    public string StaTipo { get; set; } = null!;

    public string StaEstado { get; set; } = null!;

    public string StaAgendamento { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<AcessoFederacao> AcessoFederacaoIdInstalacaoFederacaoDestNavigations { get; set; } = new List<AcessoFederacao>();

    public virtual ICollection<AcessoFederacao> AcessoFederacaoIdInstalacaoFederacaoRemNavigations { get; set; } = new List<AcessoFederacao>();

    public virtual ICollection<AndamentoInstalacao> AndamentoInstalacaos { get; set; } = new List<AndamentoInstalacao>();

    public virtual ICollection<OrgaoFederacao> OrgaoFederacaos { get; set; } = new List<OrgaoFederacao>();

    public virtual ICollection<ProtocoloFederacao> ProtocoloFederacaos { get; set; } = new List<ProtocoloFederacao>();

    public virtual ICollection<ReplicacaoFederacao> ReplicacaoFederacaos { get; set; } = new List<ReplicacaoFederacao>();

    public virtual ICollection<SinalizacaoFederacao> SinalizacaoFederacaos { get; set; } = new List<SinalizacaoFederacao>();

    public virtual ICollection<UnidadeFederacao> UnidadeFederacaos { get; set; } = new List<UnidadeFederacao>();

    public virtual ICollection<UsuarioFederacao> UsuarioFederacaos { get; set; } = new List<UsuarioFederacao>();
}
