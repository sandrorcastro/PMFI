using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscReceitaItem
    {
        public int RecItemId { get; set; }
        public int RecId { get; set; }
        public int? Quant { get; set; }
        public int? MedId { get; set; }

        public virtual TribFiscMedicamento? Med { get; set; }
        public virtual TribFiscReceitum Rec { get; set; } = null!;
    }
}
