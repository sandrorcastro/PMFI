using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class LrffiltrosTributosBimestre
    {
        public int TipoTribId { get; set; }
        public string Filtro { get; set; } = null!;
    }
}
