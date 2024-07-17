using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribZonaLimite
    {
        public short ZoliId { get; set; }
        public short? ZotiId { get; set; }
        public decimal? ZoliQuantidade { get; set; }
        public string? ZoliUnidadeMedida { get; set; }
        /// <summary>
        /// Pode ser: &apos;=&apos;, &apos;&gt;=&apos;, &apos;&lt;=&apos;, &apos;&gt;&apos;, &apos;&gt;&apos; e &apos;&lt;&gt;&apos;
        /// </summary>
        public string? ZoliOperador { get; set; }
        public string? ZoliObservacoes { get; set; }
        public short? ZozoId { get; set; }

        public virtual TribZonaTipoLimite? Zoti { get; set; }
        public virtual TribZonaZoneamento? Zozo { get; set; }
    }
}
