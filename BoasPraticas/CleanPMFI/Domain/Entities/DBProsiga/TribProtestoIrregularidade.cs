using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProtestoIrregularidade
    {
        public short IdIrregularidade { get; set; }
        public string? Descricao { get; set; }
    }
}
