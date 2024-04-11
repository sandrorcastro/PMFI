using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraAgendamentoTarefa
{
    public int IdInfraAgendamentoTarefa { get; set; }

    public string Descricao { get; set; } = null!;

    public string Comando { get; set; } = null!;

    public string StaPeriodicidadeExecucao { get; set; } = null!;

    public string? PeriodicidadeComplemento { get; set; }

    public DateTime? DthUltimaExecucao { get; set; }

    public DateTime? DthUltimaConclusao { get; set; }

    public string SinSucesso { get; set; } = null!;

    public string? Parametro { get; set; }

    public string? EmailErro { get; set; }

    public string SinAtivo { get; set; } = null!;
}
