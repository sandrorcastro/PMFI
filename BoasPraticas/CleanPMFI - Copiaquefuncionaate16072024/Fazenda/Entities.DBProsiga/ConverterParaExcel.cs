using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ConverterParaExcel
{
    public DateTime? DataInicial { get; set; }

    public DateTime? DataFinal { get; set; }

    public string? Cnpjempresa { get; set; }
}
