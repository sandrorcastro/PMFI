using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraRegraAuditorium
{
    public int IdInfraRegraAuditoria { get; set; }

    public string Descricao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<InfraRegraAuditoriaRecurso> InfraRegraAuditoriaRecursos { get; set; } = new List<InfraRegraAuditoriaRecurso>();
}
