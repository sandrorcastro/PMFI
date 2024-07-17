using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwFatoSimplesNacionalProsiga
    {
        public string? CnpjCpf { get; set; }
        public DateTime? DataDaBaixa { get; set; }
        public decimal? ValorPago { get; set; }
    }
}
