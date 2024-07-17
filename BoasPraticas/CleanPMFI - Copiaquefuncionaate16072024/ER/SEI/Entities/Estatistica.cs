using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Estatistica
{
    public long IdEstatisticas { get; set; }

    public long? IdProcedimento { get; set; }

    public long? IdDocumento { get; set; }

    public int? IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public long? TempoAberto { get; set; }

    public DateTime DthSnapshot { get; set; }

    public DateTime? DthAbertura { get; set; }

    public DateTime? DthConclusao { get; set; }

    public int? IdTipoProcedimento { get; set; }

    public long? Quantidade { get; set; }
}
