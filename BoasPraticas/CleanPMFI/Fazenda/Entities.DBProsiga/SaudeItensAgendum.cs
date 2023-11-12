using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeItensAgendum
{
    public long IdagendaItens { get; set; }

    public long Idagenda { get; set; }

    public long? IdPaciente { get; set; }

    public DateTime Data { get; set; }

    public DateTime? Hora { get; set; }

    public string? TipoConsulta { get; set; }

    public string? Situacao { get; set; }

    public string? Motivo { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public int? IdUnidadeSaudeInclusao { get; set; }

    public long? AtendId { get; set; }

    public virtual SaudePacienteXxxxxx? IdPacienteNavigation { get; set; }

    public virtual SaudeAgendaXxxxxx IdagendaNavigation { get; set; } = null!;
}
