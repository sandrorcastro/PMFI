using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Protocolo
{
    public long IdProtocolo { get; set; }

    public int IdUnidadeGeradora { get; set; }

    public int IdUsuarioGerador { get; set; }

    public string ProtocoloFormatado { get; set; } = null!;

    public string StaProtocolo { get; set; } = null!;

    public long IdProtocoloAgrupador { get; set; }

    public DateTime DtaGeracao { get; set; }

    public string StaEstado { get; set; } = null!;

    public string? Descricao { get; set; }

    public string StaNivelAcessoLocal { get; set; } = null!;

    public string StaNivelAcessoGlobal { get; set; } = null!;

    public string ProtocoloFormatadoPesquisa { get; set; } = null!;

    public string? CodigoBarras { get; set; }

    public int? IdHipoteseLegal { get; set; }

    public string? StaGrauSigilo { get; set; }

    public string? StaNivelAcessoOriginal { get; set; }

    public string ProtocoloFormatadoPesqInv { get; set; } = null!;

    public DateTime DtaInclusao { get; set; }

    public string? IdProtocoloFederacao { get; set; }

    public string SinEliminado { get; set; } = null!;

    public virtual ICollection<Acesso> Acessos { get; set; } = new List<Acesso>();

    public virtual ICollection<Acompanhamento> Acompanhamentos { get; set; } = new List<Acompanhamento>();

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ICollection<Anotacao> Anotacaos { get; set; } = new List<Anotacao>();

    public virtual Arquivamento? Arquivamento { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual ICollection<ControlePrazo> ControlePrazos { get; set; } = new List<ControlePrazo>();

    public virtual Documento? Documento { get; set; }

    public virtual HipoteseLegal? IdHipoteseLegalNavigation { get; set; }

    public virtual ProtocoloFederacao? IdProtocoloFederacaoNavigation { get; set; }

    public virtual Unidade IdUnidadeGeradoraNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioGeradorNavigation { get; set; } = null!;

    public virtual ICollection<Observacao> Observacaos { get; set; } = new List<Observacao>();

    public virtual ICollection<Participante> Participantes { get; set; } = new List<Participante>();

    public virtual Procedimento? Procedimento { get; set; }

    public virtual ICollection<ProtocoloModelo> ProtocoloModelos { get; set; } = new List<ProtocoloModelo>();

    public virtual ICollection<ReaberturaProgramadum> ReaberturaProgramada { get; set; } = new List<ReaberturaProgramadum>();

    public virtual ICollection<RelBlocoProtocolo> RelBlocoProtocolos { get; set; } = new List<RelBlocoProtocolo>();

    public virtual ICollection<RelProtocoloAssunto> RelProtocoloAssuntos { get; set; } = new List<RelProtocoloAssunto>();

    public virtual ICollection<RelProtocoloAtributo> RelProtocoloAtributos { get; set; } = new List<RelProtocoloAtributo>();

    public virtual ICollection<RelProtocoloProtocolo> RelProtocoloProtocoloIdProtocolo1Navigations { get; set; } = new List<RelProtocoloProtocolo>();

    public virtual ICollection<RelProtocoloProtocolo> RelProtocoloProtocoloIdProtocolo2Navigations { get; set; } = new List<RelProtocoloProtocolo>();

    public virtual ICollection<RetornoProgramado> RetornoProgramados { get; set; } = new List<RetornoProgramado>();

    public virtual ICollection<AcessoExterno> IdAcessoExternos { get; set; } = new List<AcessoExterno>();
}
