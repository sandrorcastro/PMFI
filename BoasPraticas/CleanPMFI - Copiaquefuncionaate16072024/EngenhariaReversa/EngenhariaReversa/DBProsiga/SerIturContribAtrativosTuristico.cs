using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturContribAtrativosTuristico
    {
        public long ConId { get; set; }
        public long AtrativoId { get; set; }
        /// <summary>
        /// Sim ou Não
        /// </summary>
        public string? Proprietario { get; set; }
        /// <summary>
        /// Sim ou Não
        /// </summary>
        public string? Responsavel { get; set; }

        public virtual SerIturAtrativosTuristico Atrativo { get; set; } = null!;
        public virtual Contribuinte Con { get; set; } = null!;
    }
}
