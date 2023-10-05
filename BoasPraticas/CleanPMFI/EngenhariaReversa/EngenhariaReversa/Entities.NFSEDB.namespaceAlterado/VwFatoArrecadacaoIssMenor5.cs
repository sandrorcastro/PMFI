using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class VwFatoArrecadacaoIssMenor5
    {
        public int? Empresa { get; set; }
        public DateTime? DataDaCompetencia { get; set; }
        public string? Serviço { get; set; }
        public string? Cnae { get; set; }
        public decimal? Aliquota { get; set; }
        public decimal? ValorIssTotal { get; set; }
    }
}
