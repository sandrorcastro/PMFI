using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ProtocoloFederacao
{
    public string IdProtocoloFederacao { get; set; } = null!;

    public string IdInstalacaoFederacao { get; set; } = null!;

    public string ProtocoloFormatado { get; set; } = null!;

    public string ProtocoloFormatadoPesquisa { get; set; } = null!;

    public string ProtocoloFormatadoPesqInv { get; set; } = null!;

    public virtual ICollection<AcessoFederacao> AcessoFederacaoIdDocumentoFederacaoNavigations { get; set; } = new List<AcessoFederacao>();

    public virtual ICollection<AcessoFederacao> AcessoFederacaoIdProcedimentoFederacaoNavigations { get; set; } = new List<AcessoFederacao>();

    public virtual InstalacaoFederacao IdInstalacaoFederacaoNavigation { get; set; } = null!;

    public virtual ICollection<Protocolo> Protocolos { get; set; } = new List<Protocolo>();

    public virtual ICollection<ReplicacaoFederacao> ReplicacaoFederacaos { get; set; } = new List<ReplicacaoFederacao>();

    public virtual ICollection<SinalizacaoFederacao> SinalizacaoFederacaos { get; set; } = new List<SinalizacaoFederacao>();
}
