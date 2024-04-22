using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribZonaMensagem
{
    public short ZomsId { get; set; }

    public string? ZomsMensagem { get; set; }

    public string? ZomsImprimeGuia { get; set; }
}
