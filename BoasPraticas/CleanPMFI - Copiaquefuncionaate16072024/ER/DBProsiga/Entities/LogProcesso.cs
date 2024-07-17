using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LogProcesso
{
    public long LogId { get; set; }

    public string? LogTipo { get; set; }

    public DateTime? LogData { get; set; }

    public string? LogUsuario { get; set; }

    public long? LogProcessoId { get; set; }

    public string? LogOcorrencia { get; set; }

    public virtual Processo? LogProcessoNavigation { get; set; }
}
