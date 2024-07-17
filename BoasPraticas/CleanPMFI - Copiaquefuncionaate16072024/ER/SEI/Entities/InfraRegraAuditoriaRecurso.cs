using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraRegraAuditoriaRecurso
{
    public int IdInfraRegraAuditoria { get; set; }

    public string Recurso { get; set; } = null!;

    public virtual InfraRegraAuditorium IdInfraRegraAuditoriaNavigation { get; set; } = null!;
}
