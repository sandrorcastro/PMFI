using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribZonaTipoLimite
    {
        public TribZonaTipoLimite()
        {
            TribZonaLimites = new HashSet<TribZonaLimite>();
        }

        public short ZotiId { get; set; }
        public string? ZotiNome { get; set; }
        /// <summary>
        /// Utilizado para ordenar os limites no relatório que demonstra os detalhes do zoneamento e na consulta de alvará.
        /// </summary>
        public short? ZotiOrdenacao { get; set; }

        public virtual ICollection<TribZonaLimite> TribZonaLimites { get; set; }
    }
}
