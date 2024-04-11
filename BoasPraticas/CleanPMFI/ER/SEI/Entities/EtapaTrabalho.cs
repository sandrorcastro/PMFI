using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EtapaTrabalho
{
    public int IdEtapaTrabalho { get; set; }

    public int IdPlanoTrabalho { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public int Ordem { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual PlanoTrabalho IdPlanoTrabalhoNavigation { get; set; } = null!;

    public virtual ICollection<ItemEtapa> ItemEtapas { get; set; } = new List<ItemEtapa>();
}
