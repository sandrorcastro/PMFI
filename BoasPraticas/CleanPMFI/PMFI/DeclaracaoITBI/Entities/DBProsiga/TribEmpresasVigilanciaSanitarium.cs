using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasVigilanciaSanitarium
{
    public int IdEmprVigilancia { get; set; }

    public long? EmprCmc { get; set; }

    public long? NrNumero { get; set; }

    public long? NrAno { get; set; }

    public DateTime? DtValidade { get; set; }

    public DateTime? DtVistoria { get; set; }

    public string? DsObservacao { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }
}
