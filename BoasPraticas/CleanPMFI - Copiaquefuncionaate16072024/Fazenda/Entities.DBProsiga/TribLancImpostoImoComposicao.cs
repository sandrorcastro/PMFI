using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribLancImpostoImoComposicao
{
    public int LanImpCompId { get; set; }

    public int LanImpImoAno { get; set; }

    public long EdificacaoId { get; set; }

    public int TipoTribId { get; set; }

    public string? TipoTribSiglaTributo { get; set; }

    public string? TipoTribNome { get; set; }

    public decimal? LanImpImoCompValor { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? HostInclusao { get; set; }

    public int? LanImpId { get; set; }

    public virtual TribLancImpostoImo? LanImp { get; set; }
}
