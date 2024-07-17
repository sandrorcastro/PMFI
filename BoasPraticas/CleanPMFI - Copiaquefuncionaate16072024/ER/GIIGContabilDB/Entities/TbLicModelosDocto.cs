using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicModelosDocto
{
    public short IdModelo { get; set; }

    public short? IdEmpresa { get; set; }

    public string? NmModelo { get; set; }

    public short? IdTipoDocumento { get; set; }

    public virtual TbLicTiposDocumento? IdTipoDocumentoNavigation { get; set; }

    public virtual ICollection<TbCntTiposContrato> TbCntTiposContratos { get; set; } = new List<TbCntTiposContrato>();

    public virtual ICollection<TbLicClausula> TbLicClausulas { get; set; } = new List<TbLicClausula>();

    public virtual ICollection<TbLicLicitacoesDocumento> TbLicLicitacoesDocumentos { get; set; } = new List<TbLicLicitacoesDocumento>();
}
