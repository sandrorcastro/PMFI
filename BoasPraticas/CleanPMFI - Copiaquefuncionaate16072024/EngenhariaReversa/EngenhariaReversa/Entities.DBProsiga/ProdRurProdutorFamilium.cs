using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurProdutorFamilium
    {
        public int Idprodutor { get; set; }
        public long ConId { get; set; }
        public string? NivelParent { get; set; }
        public string? SairNota { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual ProdRurProdutor IdprodutorNavigation { get; set; } = null!;
    }
}
