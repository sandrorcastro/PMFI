﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SecaoServico
{
    public int? Distrito { get; set; }

    public string? LadoSecao { get; set; }

    public int? Logradouro { get; set; }

    public int? Secao { get; set; }

    public int? Servico { get; set; }

    public int? Setor { get; set; }

    public int? Periodicidade { get; set; }
}
