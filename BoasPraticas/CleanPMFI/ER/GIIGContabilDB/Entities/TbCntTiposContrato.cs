using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposContrato
{
    public short IdTipoContrato { get; set; }

    public string? DsTipoContrato { get; set; }

    public short? IdModelo { get; set; }

    public bool? FlUsaAta { get; set; }

    public virtual TbLicModelosDocto? IdModeloNavigation { get; set; }

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();
}
