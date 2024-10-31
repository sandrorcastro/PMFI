using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AguaCategoria
    {
        public AguaCategoria()
        {
            AguaCategoriaTributos = new HashSet<AguaCategoriaTributo>();
            AguaTarifasAguas = new HashSet<AguaTarifasAgua>();
        }

        /// <summary>
        /// Código de identificação da categoria de cobrança da água.
        /// </summary>
        public int CategId { get; set; }
        /// <summary>
        /// Nome da categoria de cobrança da água.
        /// </summary>
        public string? CategNome { get; set; }

        public virtual ICollection<AguaCategoriaTributo> AguaCategoriaTributos { get; set; }
        public virtual ICollection<AguaTarifasAgua> AguaTarifasAguas { get; set; }
    }
}
