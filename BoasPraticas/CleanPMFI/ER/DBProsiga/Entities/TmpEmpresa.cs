﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TmpEmpresa
{
    public int EmprCmc { get; set; }

    public int? ConId { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? ConNome { get; set; }
}
