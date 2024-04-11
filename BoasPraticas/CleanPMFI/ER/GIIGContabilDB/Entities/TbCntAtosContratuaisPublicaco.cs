using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntAtosContratuaisPublicaco
{
    public int IdNumeroAto { get; set; }

    public int IdOrgaoOficial { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public virtual TbCntNumeroAtosContratuai IdNumeroAtoNavigation { get; set; } = null!;

    public virtual TbGerOrgaoOficialPublicacao IdOrgaoOficialNavigation { get; set; } = null!;
}
