﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TmpsislogdadosEmp
{
    public string? Objetoocorrencia { get; set; }

    public DateTime? Datahora { get; set; }

    public long? Iddivida { get; set; }

    public DateTime? Vencimento { get; set; }
}
