using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissTipoServicoTributo
{
    public int TipoTribId { get; set; }

    public long ServTpId { get; set; }

    public long? TpSerTribDiasVencimento { get; set; }

    public virtual FissTipoServico ServTp { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
