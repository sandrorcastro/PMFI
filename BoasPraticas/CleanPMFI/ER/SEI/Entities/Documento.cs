using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Documento
{
    public long IdDocumento { get; set; }

    public string? Numero { get; set; }

    public int IdUnidadeResponsavel { get; set; }

    public long? IdDocumentoEdoc { get; set; }

    public int IdSerie { get; set; }

    public long IdProcedimento { get; set; }

    public string SinBloqueado { get; set; } = null!;

    public int? IdConjuntoEstilos { get; set; }

    public int? IdTipoConferencia { get; set; }

    public int? IdTipoFormulario { get; set; }

    public string StaDocumento { get; set; } = null!;

    public string? NomeArvore { get; set; }

    public string SinArquivamento { get; set; } = null!;

    public string SinVersoes { get; set; } = null!;

    public decimal? DinValor { get; set; }

    public string StaEditor { get; set; } = null!;

    public virtual ICollection<AcessoExterno> AcessoExternos { get; set; } = new List<AcessoExterno>();

    public virtual ICollection<Assinatura> Assinaturas { get; set; } = new List<Assinatura>();

    public virtual DocumentoConteudo? DocumentoConteudo { get; set; }

    public virtual DocumentoGeracao? DocumentoGeracao { get; set; }

    public virtual ICollection<EditalEliminacao> EditalEliminacaos { get; set; } = new List<EditalEliminacao>();

    public virtual ConjuntoEstilo? IdConjuntoEstilosNavigation { get; set; }

    public virtual Protocolo IdDocumentoNavigation { get; set; } = null!;

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual Serie IdSerieNavigation { get; set; } = null!;

    public virtual TipoConferencium? IdTipoConferenciaNavigation { get; set; }

    public virtual TipoFormulario? IdTipoFormularioNavigation { get; set; }

    public virtual Unidade IdUnidadeResponsavelNavigation { get; set; } = null!;

    public virtual Publicacao? Publicacao { get; set; }

    public virtual ICollection<RelNotificacaoDocumento> RelNotificacaoDocumentos { get; set; } = new List<RelNotificacaoDocumento>();

    public virtual ICollection<SecaoDocumento> SecaoDocumentos { get; set; } = new List<SecaoDocumento>();

    public virtual ICollection<ItemEtapa> IdItemEtapas { get; set; } = new List<ItemEtapa>();
}
