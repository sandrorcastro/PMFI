using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflTiposFluxo
{
    public short IdTipoFluxo { get; set; }

    public string? NmTipoFluxo { get; set; }

    public string? DsTipoFluxo { get; set; }

    public string? FlRestringeOrgaoUnidade { get; set; }

    public virtual ICollection<TbWflFluxosTramitacao> TbWflFluxosTramitacaos { get; set; } = new List<TbWflFluxosTramitacao>();

    public virtual ICollection<TbWflRemessa> TbWflRemessaIdTipoFluxoDestinoNavigations { get; set; } = new List<TbWflRemessa>();

    public virtual ICollection<TbWflRemessa> TbWflRemessaIdTipoFluxoRemetenteNavigations { get; set; } = new List<TbWflRemessa>();
}
