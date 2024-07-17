using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerFusaoCisaoExtincaoEmpresa
{
    public short IdFusaoCisaoExtincao { get; set; }

    public short? IdEmpresaOrigem { get; set; }

    public short? IdEmpresaDestino { get; set; }

    public DateTime? DtOperacao { get; set; }

    public string? DsOperacao { get; set; }

    public string? TpOperacao { get; set; }

    public bool? FlLiberadoLancto { get; set; }
}
