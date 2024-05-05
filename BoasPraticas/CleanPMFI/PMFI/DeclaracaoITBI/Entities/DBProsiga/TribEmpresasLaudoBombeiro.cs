using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasLaudoBombeiro
{
    public int IdempresaLaudo { get; set; }

    public long? EmprCmc { get; set; }

    public long? Numero { get; set; }

    public long? Ano { get; set; }

    public DateTime? DataValidate { get; set; }

    public DateTime? DataVistoria { get; set; }

    public string? DsObservacao { get; set; }
}
