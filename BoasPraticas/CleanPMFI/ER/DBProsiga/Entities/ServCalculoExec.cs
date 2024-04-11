using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ServCalculoExec
{
    public int Id { get; set; }

    public DateTime? DataIni { get; set; }

    public DateTime? DataFim { get; set; }

    public DateTime? DataExec { get; set; }

    public long? Qtde { get; set; }
}
