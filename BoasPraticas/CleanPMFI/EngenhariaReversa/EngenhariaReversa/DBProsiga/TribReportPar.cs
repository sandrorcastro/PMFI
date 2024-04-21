using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribReportPar
    {
        public int RparId { get; set; }
        public string? RparSessionId { get; set; }
        public string? RparParametro { get; set; }
        public string? RparTipo { get; set; }
        public string? RparValor { get; set; }
    }
}
