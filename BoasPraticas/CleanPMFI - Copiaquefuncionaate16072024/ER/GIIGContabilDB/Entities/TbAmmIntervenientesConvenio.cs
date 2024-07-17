using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmIntervenientesConvenio
{
    public int IdInterveniente { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdConvenioAuxilio { get; set; }

    public string? NrCnpj { get; set; }

    public string? CdResponsabilidade { get; set; }

    public string? NmInterveniente { get; set; }
}
