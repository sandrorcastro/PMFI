using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class Divergencium
    {
        public int Conta { get; set; }
        public decimal? ValorDeclarado { get; set; }
        public decimal? Credito { get; set; }
        public decimal? Debito { get; set; }
    }
}
