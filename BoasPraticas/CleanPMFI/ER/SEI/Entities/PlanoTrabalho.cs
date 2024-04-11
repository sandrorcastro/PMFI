using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class PlanoTrabalho
{
    public int IdPlanoTrabalho { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<AndamentoPlanoTrabalho> AndamentoPlanoTrabalhos { get; set; } = new List<AndamentoPlanoTrabalho>();

    public virtual ICollection<EtapaTrabalho> EtapaTrabalhos { get; set; } = new List<EtapaTrabalho>();

    public virtual ICollection<Procedimento> Procedimentos { get; set; } = new List<Procedimento>();

    public virtual ICollection<TipoProcedimento> TipoProcedimentos { get; set; } = new List<TipoProcedimento>();

    public virtual ICollection<Serie> IdSeries { get; set; } = new List<Serie>();
}
