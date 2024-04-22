using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscAssunto
    {
        public int IdAssunto { get; set; }
        public int TipoFiscId { get; set; }
        public string? DsAssunto { get; set; }
    }
}
