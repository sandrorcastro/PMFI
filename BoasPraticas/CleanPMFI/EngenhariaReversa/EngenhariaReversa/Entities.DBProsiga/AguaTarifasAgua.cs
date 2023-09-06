using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AguaTarifasAgua
    {
        public int TarifAgId { get; set; }
        public decimal? TarifAgDe { get; set; }
        public decimal? TarifAgAte { get; set; }
        public decimal? TarifAgValor { get; set; }
        public string? TarifAgTaxaMinima { get; set; }
        public string? TarifAgMetroCubico { get; set; }
        public int? CategId { get; set; }

        public virtual AguaCategoria? Categ { get; set; }
    }
}
