using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VisaoRecebimento
{
    public long RecIdrecebimento { get; set; }

    public DateTime? CargaData { get; set; }

    public DateTime? RecData { get; set; }

    public string? ServNome { get; set; }

    public long? CargaProcId { get; set; }

    public long CargaId { get; set; }
}
