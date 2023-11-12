using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ComponentesServico
{
    public int CompServicosId { get; set; }

    public string? CompServNome { get; set; }

    public virtual ICollection<Acessorio> Acessorios { get; set; } = new List<Acessorio>();

    public virtual ICollection<DetalhesManutencaoMovEq> DetalhesManutencaoMovEqs { get; set; } = new List<DetalhesManutencaoMovEq>();

    public virtual ICollection<DetalhesManutencao> DetalhesManutencaos { get; set; } = new List<DetalhesManutencao>();

    public virtual ICollection<ItensManutencaoMovEquip> ItensManutencaoMovEquips { get; set; } = new List<ItensManutencaoMovEquip>();

    public virtual ICollection<ItensManutencao> ItensManutencaos { get; set; } = new List<ItensManutencao>();
}
