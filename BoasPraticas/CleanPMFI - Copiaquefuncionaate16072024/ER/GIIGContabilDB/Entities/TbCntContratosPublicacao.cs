using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntContratosPublicacao
{
    public int IdContrato { get; set; }

    public int IdOrgaoOficial { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;

    public virtual TbGerOrgaoOficialPublicacao IdOrgaoOficialNavigation { get; set; } = null!;
}
