using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TmpImportarVistoria
{
    public DateTime? Data { get; set; }

    public string? Cmc { get; set; }

    public string? Documento { get; set; }

    public string? Procedimento { get; set; }

    public string? RazãoSocial { get; set; }

    public int? EmprCmc { get; set; }

    public int? NumeroLaudo { get; set; }

    public bool? Importado { get; set; }

    public short? Ano { get; set; }
}
