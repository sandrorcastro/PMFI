using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmDotacoesEstaduaisConvenio
{
    public int IdDotacaoEstadual { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdConvenioAuxilio { get; set; }

    public string? CdDotacao { get; set; }
}
