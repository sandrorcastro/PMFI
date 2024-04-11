using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaMensagem
{
    public short ZomsId { get; set; }

    public string? ZomsMensagem { get; set; }

    public string? ZomsImprimeGuia { get; set; }
}
