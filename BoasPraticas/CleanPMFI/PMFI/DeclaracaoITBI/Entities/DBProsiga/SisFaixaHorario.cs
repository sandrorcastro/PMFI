using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SisFaixaHorario
{
    /// <summary>
    /// Identificação da faixa do horário.
    /// </summary>
    public short FaHoId { get; set; }

    /// <summary>
    /// Hora, Minuto e Segundo  inicial permitido para faixa.
    /// </summary>
    public DateTime? FaHoPeriodoIni { get; set; }

    /// <summary>
    /// Hora, Minuto e Segundo Final permitido para faixa.
    /// </summary>
    public DateTime? FaHoPeriodoFinal { get; set; }

    public virtual ICollection<SisTarefa> TiJos { get; set; } = new List<SisTarefa>();
}
