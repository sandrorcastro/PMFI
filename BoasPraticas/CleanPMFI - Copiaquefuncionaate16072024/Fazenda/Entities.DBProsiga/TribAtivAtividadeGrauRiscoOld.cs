﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAtivAtividadeGrauRiscoOld
{
    public string Atividade { get; set; } = null!;

    public short SetorId { get; set; }

    public string? Risco { get; set; }
}
