using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TemptribAtividadeTipoAlvaraTributo
{
    public string Atividade { get; set; } = null!;

    public int TipoTribId { get; set; }

    public int TalvId { get; set; }
}
