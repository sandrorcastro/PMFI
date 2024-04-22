using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaZoneamento
    {
        public TribZonaZoneamento()
        {
            TbtribZonaZoneamentoAtividadePergunta = new HashSet<TbtribZonaZoneamentoAtividadePergunta>();
            TribZonaLimites = new HashSet<TribZonaLimite>();
            TribZonaZoneamentoAtividades = new HashSet<TribZonaZoneamentoAtividade>();
            TribZonaZoneamentoQuadraLograds = new HashSet<TribZonaZoneamentoQuadraLograd>();
            TribZonaZoneamentoUsos = new HashSet<TribZonaZoneamentoUso>();
        }

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

        public virtual TribZona? Zona { get; set; }
        public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; }
        public virtual ICollection<TribZonaLimite> TribZonaLimites { get; set; }
        public virtual ICollection<TribZonaZoneamentoAtividade> TribZonaZoneamentoAtividades { get; set; }
        public virtual ICollection<TribZonaZoneamentoQuadraLograd> TribZonaZoneamentoQuadraLograds { get; set; }
        public virtual ICollection<TribZonaZoneamentoUso> TribZonaZoneamentoUsos { get; set; }
    }
}
