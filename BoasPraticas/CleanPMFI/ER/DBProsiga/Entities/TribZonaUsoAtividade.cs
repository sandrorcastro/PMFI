﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaUsoAtividade
{
    public short ZousId { get; set; }

    public string Atividade { get; set; } = null!;

    public short ZotlId { get; set; }

    public virtual TribZonaTipoLiberacao Zotl { get; set; } = null!;
}
