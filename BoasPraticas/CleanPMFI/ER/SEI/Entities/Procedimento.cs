using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Procedimento
{
    public long IdProcedimento { get; set; }

    public int IdTipoProcedimento { get; set; }

    public string StaOuvidoria { get; set; } = null!;

    public string SinCiencia { get; set; } = null!;

    public int? IdPlanoTrabalho { get; set; }

    public DateTime? DtaConclusao { get; set; }

    public DateTime? DtaEliminacao { get; set; }

    public int? IdTipoPrioridade { get; set; }

    public virtual ICollection<AndamentoMarcador> AndamentoMarcadors { get; set; } = new List<AndamentoMarcador>();

    public virtual ICollection<AndamentoPlanoTrabalho> AndamentoPlanoTrabalhos { get; set; } = new List<AndamentoPlanoTrabalho>();

    public virtual ICollection<AndamentoSituacao> AndamentoSituacaos { get; set; } = new List<AndamentoSituacao>();

    public virtual ICollection<AvaliacaoDocumental> AvaliacaoDocumentals { get; set; } = new List<AvaliacaoDocumental>();

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EditalEliminacao> EditalEliminacaos { get; set; } = new List<EditalEliminacao>();

    public virtual PlanoTrabalho? IdPlanoTrabalhoNavigation { get; set; }

    public virtual Protocolo IdProcedimentoNavigation { get; set; } = null!;

    public virtual TipoPrioridade? IdTipoPrioridadeNavigation { get; set; }

    public virtual TipoProcedimento IdTipoProcedimentoNavigation { get; set; } = null!;

    public virtual ICollection<Notificacao> Notificacaos { get; set; } = new List<Notificacao>();
}
