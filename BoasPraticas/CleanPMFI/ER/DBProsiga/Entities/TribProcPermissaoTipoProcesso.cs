﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcPermissaoTipoProcesso
{
    public string UsuId { get; set; } = null!;

    public int ProcTipoProcId { get; set; }
}
