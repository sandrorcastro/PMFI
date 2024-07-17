using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class MonitoramentoServico
{
    public long IdMonitoramentoServico { get; set; }

    public int IdServico { get; set; }

    public string Operacao { get; set; } = null!;

    public long TempoExecucao { get; set; }

    public string? IpAcesso { get; set; }

    public DateTime DthAcesso { get; set; }

    public string? Servidor { get; set; }

    public string? UserAgent { get; set; }

    public virtual Servico IdServicoNavigation { get; set; } = null!;
}
