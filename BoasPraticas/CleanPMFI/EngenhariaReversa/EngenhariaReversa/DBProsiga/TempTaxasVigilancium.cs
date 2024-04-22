using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TempTaxasVigilancium
    {
        public DateTime? Data { get; set; }
        public int? Cmc { get; set; }
        public string? Doc { get; set; }
        public string? Procedimento { get; set; }
        public string? Razao { get; set; }
    }
}
