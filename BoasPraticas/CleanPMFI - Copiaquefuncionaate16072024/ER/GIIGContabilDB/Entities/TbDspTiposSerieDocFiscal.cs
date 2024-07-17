using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspTiposSerieDocFiscal
{
    public short IdTipoSerieDocFiscal { get; set; }

    public string? DsTipoSerieDocFiscal { get; set; }

    public short? CdTc { get; set; }

    public short? IdSerieFiss { get; set; }

    public bool? FlAtivo { get; set; }

    public virtual ICollection<TbDspDocumentosFiscai> TbDspDocumentosFiscais { get; set; } = new List<TbDspDocumentosFiscai>();

    public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; } = new List<TbDspLiquidacoesDocumento>();
}
