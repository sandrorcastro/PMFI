using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fzreferencia
    {
        public Fzreferencia()
        {
            Fztaxas = new HashSet<Fztaxa>();
        }

        public int TxReferId { get; set; }
        public decimal? TxReferValor { get; set; }
        /// <summary>
        /// valores de referencias para as taxas
        /// </summary>
        public string? TxReferNome { get; set; }

        public virtual ICollection<Fztaxa> Fztaxas { get; set; }
    }
}
