using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflFluxosTramitacao
{
    public short IdFluxoTramitacao { get; set; }

    public short? IdTipoProcesso { get; set; }

    public short? IdTipoFluxo { get; set; }

    public short? NrFluxoTramitacao { get; set; }

    public virtual TbWflTiposFluxo? IdTipoFluxoNavigation { get; set; }

    public virtual TbWflTiposProcesso? IdTipoProcessoNavigation { get; set; }

    public virtual ICollection<TbWflDespachosFluxo> TbWflDespachosFluxos { get; set; } = new List<TbWflDespachosFluxo>();
}
