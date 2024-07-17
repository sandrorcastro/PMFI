using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSecao
{
    public int SecaoId { get; set; }

    public string? Secao { get; set; }

    public decimal? VlrMetroQuadrado { get; set; }

    public int? QuadraId { get; set; }

    public int? LogradId { get; set; }

    public virtual TribQuadraLograd? TribQuadraLograd { get; set; }

    public virtual ICollection<TribSecaoVlrM2pAno> TribSecaoVlrM2pAnos { get; set; } = new List<TribSecaoVlrM2pAno>();

    public virtual ICollection<TribTipoTributo> TipoTribs { get; set; } = new List<TribTipoTributo>();
}
