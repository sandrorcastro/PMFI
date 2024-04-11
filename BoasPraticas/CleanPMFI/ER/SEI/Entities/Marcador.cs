using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Marcador
{
    public int IdMarcador { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? SinAtivo { get; set; }

    public string StaIcone { get; set; } = null!;

    public int IdUnidade { get; set; }

    public virtual ICollection<AndamentoMarcador> AndamentoMarcadors { get; set; } = new List<AndamentoMarcador>();

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
