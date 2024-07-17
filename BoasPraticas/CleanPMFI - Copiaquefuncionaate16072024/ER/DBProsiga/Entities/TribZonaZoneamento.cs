using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaZoneamento
{
    public short ZozoId { get; set; }

    public string? ZozoSigla { get; set; }

    public string? ZozoNome { get; set; }

    public short? ZonaId { get; set; }

    public string? ZozoObservacoes { get; set; }

    /// <summary>
    /// Ordem em que o limite será apresentado no relatório de detalhamento e consulta prévia.
    /// </summary>
    public short? ZoliOrdenacao { get; set; }

    /// <summary>
    /// Informa que o zoneamento vai utilizar os parametros de outro zoneamento.
    /// </summary>
    public short? ZozoIdorigem { get; set; }

    public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; } = new List<TbtribZonaZoneamentoAtividadePergunta>();

    public virtual ICollection<TribZonaLimite> TribZonaLimites { get; set; } = new List<TribZonaLimite>();

    public virtual ICollection<TribZonaZoneamentoAtividade> TribZonaZoneamentoAtividades { get; set; } = new List<TribZonaZoneamentoAtividade>();

    public virtual ICollection<TribZonaZoneamentoQuadraLograd> TribZonaZoneamentoQuadraLograds { get; set; } = new List<TribZonaZoneamentoQuadraLograd>();

    public virtual ICollection<TribZonaZoneamentoUso> TribZonaZoneamentoUsos { get; set; } = new List<TribZonaZoneamentoUso>();

    public virtual TribZona? Zona { get; set; }
}
