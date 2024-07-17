using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspCodigosFiscaisOperacoesPrestaco
{
    public int CdCfop { get; set; }

    public string? DsCfop { get; set; }

    public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; } = new List<TbDspLiquidacoesDocumento>();
}
