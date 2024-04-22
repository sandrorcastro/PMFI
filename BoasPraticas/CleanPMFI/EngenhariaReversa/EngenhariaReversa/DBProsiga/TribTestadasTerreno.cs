using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTestadasTerreno
    {
        public long TerrenoId { get; set; }
        public int LogradId { get; set; }
        /// <summary>
        /// Sim ou Não
        /// </summary>
        public string? TestadasPrincipal { get; set; }
        public decimal? TestadasMetragem { get; set; }
        public int? SecaoId { get; set; }

        public virtual Logradouro Lograd { get; set; } = null!;
        public virtual TribTerreno Terreno { get; set; } = null!;
    }
}
