using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AgePermissao
{
    public long ServId { get; set; }

    public long AgendaId { get; set; }

    public string? PermConsulta { get; set; }

    public string? PermAgenda { get; set; }

    public DateTime? PermDataCadastro { get; set; }

    public virtual AgeAgendum Agenda { get; set; } = null!;

    public virtual Servidore Serv { get; set; } = null!;
}
