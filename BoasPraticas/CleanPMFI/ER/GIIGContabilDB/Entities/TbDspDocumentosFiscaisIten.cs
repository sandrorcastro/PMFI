using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspDocumentosFiscaisIten
{
    public int IdDoctoFiscal { get; set; }

    public int IdItem { get; set; }

    public decimal? NrQtde { get; set; }

    public decimal? VlTotal { get; set; }

    public decimal? VlDesconto { get; set; }

    public virtual TbDspDocumentosFiscai IdDoctoFiscalNavigation { get; set; } = null!;
}
