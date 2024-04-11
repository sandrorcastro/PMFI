using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspTiposDocumentosFiscai
{
    public int IdTipoDoctoFiscal { get; set; }

    public string? NmTipoDoctoFiscal { get; set; }

    public string? FlControlaVencimento { get; set; }

    public short? CdTipoTc { get; set; }

    public short? NrDiasPadrao { get; set; }

    public bool? FlAtivo { get; set; }

    public short? NrDigitosCodigoBarras { get; set; }

    public bool? FlUsaSerie { get; set; }

    public string? FlConvenio { get; set; }

    public virtual ICollection<TbDspDocumentosFiscai> TbDspDocumentosFiscais { get; set; } = new List<TbDspDocumentosFiscai>();

    public virtual ICollection<TbDspLiquidacoesDocumento> TbDspLiquidacoesDocumentos { get; set; } = new List<TbDspLiquidacoesDocumento>();

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();
}
