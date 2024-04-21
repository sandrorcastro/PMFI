using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbdoctosReferencium
{
    public int ReferenciaId { get; set; }

    public string? DoctoNome { get; set; }

    public DateTime? DoctoDataEnvio { get; set; }

    public DateTime? DoctoDataImplantacao { get; set; }

    public int? DoctoAbaNum { get; set; }

    public string? DoctoAbaNome { get; set; }

    public string? ReferenciaObs { get; set; }
}
