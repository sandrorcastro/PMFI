using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TmptribAtividadeTipoAlvaraTributo
{
    public string Atividade { get; set; } = null!;

    public int TipoTribId { get; set; }

    public int TalvId { get; set; }
}
