﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ConverterParaExcel
{
    public DateTime? DataInicial { get; set; }

    public DateTime? DataFinal { get; set; }

    public string? Cnpjempresa { get; set; }
}
