using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribCalculoSimuladoLanc
{
    public long LancId { get; set; }

    public int? SimuId { get; set; }

    public long? EdificacaoId { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    public int? TipoTribId { get; set; }

    public int? TipoBxId { get; set; }

    public decimal? LancValor { get; set; }

    public short? Incidencia { get; set; }

    public virtual TribCalculoSimulado? Simu { get; set; }
}
