using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflTiposProcesso
{
    public short IdTipoProcesso { get; set; }

    public string? NmTipoProcesso { get; set; }

    public string? FlRestringeFluxo { get; set; }

    public string? CdNatDespesas { get; set; }

    public virtual ICollection<TbDspRm> TbDspRms { get; set; } = new List<TbDspRm>();

    public virtual ICollection<TbWflFluxosTramitacao> TbWflFluxosTramitacaos { get; set; } = new List<TbWflFluxosTramitacao>();
}
