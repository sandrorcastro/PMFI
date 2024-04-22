using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ComponentesServico
    {
        public ComponentesServico()
        {
            Acessorios = new HashSet<Acessorio>();
            DetalhesManutencaoMovEqs = new HashSet<DetalhesManutencaoMovEq>();
            DetalhesManutencaos = new HashSet<DetalhesManutencao>();
            ItensManutencaoMovEquips = new HashSet<ItensManutencaoMovEquip>();
            ItensManutencaos = new HashSet<ItensManutencao>();
        }

        public int CompServicosId { get; set; }
        public string? CompServNome { get; set; }

        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<DetalhesManutencaoMovEq> DetalhesManutencaoMovEqs { get; set; }
        public virtual ICollection<DetalhesManutencao> DetalhesManutencaos { get; set; }
        public virtual ICollection<ItensManutencaoMovEquip> ItensManutencaoMovEquips { get; set; }
        public virtual ICollection<ItensManutencao> ItensManutencaos { get; set; }
    }
}
