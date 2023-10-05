using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class VwFatoSimplesNacionalNfse
    {
        public int? Empresa { get; set; }
        public DateTime? DataDaCompetencia { get; set; }
        public decimal? ValorIssTotal { get; set; }
    }
}
