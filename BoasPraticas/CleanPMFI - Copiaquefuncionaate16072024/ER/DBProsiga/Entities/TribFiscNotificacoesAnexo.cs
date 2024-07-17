using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscNotificacoesAnexo
{
    public int Anexid { get; set; }

    public int? Notifid { get; set; }

    public int? ObjetoId { get; set; }

    public string? AnexObs { get; set; }
}
