using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesDocumento
{
    public int IdLicitacaoDocumento { get; set; }

    public int IdLicitacao { get; set; }

    public short IdModelo { get; set; }

    public string? NmDocumentoLicitacao { get; set; }

    public string? DsObjeto { get; set; }

    public DateTime? DtGeracao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;

    public virtual TbLicModelosDocto IdModeloNavigation { get; set; } = null!;
}
