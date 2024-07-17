using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesDocumentosSalvo
{
    public int IdDocumentoSalvo { get; set; }

    public int? IdLicitacao { get; set; }

    public short? NrSequencia { get; set; }

    public string? NmDocumento { get; set; }

    public string? DsObjeto { get; set; }

    public DateTime? DtGeracao { get; set; }

    public string? DsLogin { get; set; }
}
