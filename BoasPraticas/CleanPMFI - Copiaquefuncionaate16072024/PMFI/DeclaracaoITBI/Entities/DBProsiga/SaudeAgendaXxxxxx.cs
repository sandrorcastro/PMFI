using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeAgendaXxxxxx
{
    public long Idagenda { get; set; }

    public int IdEscala { get; set; }

    public DateTime? DataInicial { get; set; }

    public DateTime? DataFinal { get; set; }

    public int? NroConsultas { get; set; }

    public int? NroRetornos { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public int? IdUnidadeSaudeInclusao { get; set; }

    public int? TotalVagas { get; set; }

    public string? Situacao { get; set; }

    public string? Motivo { get; set; }

    public virtual SaudeEscala IdEscalaNavigation { get; set; } = null!;

    public virtual ICollection<SaudeAgendaVaga> SaudeAgendaVagas { get; set; } = new List<SaudeAgendaVaga>();

    public virtual ICollection<SaudeItensAgendum> SaudeItensAgenda { get; set; } = new List<SaudeItensAgendum>();
}
