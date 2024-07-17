using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvaraEmpresaslog
{
    public int? AlvaraId { get; set; }

    public int? EmprCmc { get; set; }

    public DateTime? AlvDataFimAntes { get; set; }

    public DateTime? AlvDataFimDepois { get; set; }

    public DateTime? Dtinclusao { get; set; }
}
