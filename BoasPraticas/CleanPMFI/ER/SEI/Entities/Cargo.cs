using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Cargo
{
    public int IdCargo { get; set; }

    public string Expressao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public int? IdTratamento { get; set; }

    public int? IdVocativo { get; set; }

    public string? StaGenero { get; set; }

    public int? IdTitulo { get; set; }

    public virtual ICollection<Contato> Contatos { get; set; } = new List<Contato>();

    public virtual ICollection<CpadComposicao> CpadComposicaos { get; set; } = new List<CpadComposicao>();

    public virtual Titulo? IdTituloNavigation { get; set; }

    public virtual Tratamento? IdTratamentoNavigation { get; set; }

    public virtual Vocativo? IdVocativoNavigation { get; set; }
}
