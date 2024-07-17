using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribItbiexVendedore
    {
        public long ItbiedifId { get; set; }
        public long ConId { get; set; }
        public string ImprimeNaGuia { get; set; } = null!;

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual TribItbiexEdif Itbiedif { get; set; } = null!;
    }
}
