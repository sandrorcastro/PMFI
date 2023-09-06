using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AlmEntradaNovoGiiG
    {
        public long? AlmIdEmpenho { get; set; }
        public long? AlmIdItemContabil { get; set; }
        public long? AlmIdItemAlmox { get; set; }
        public string? AlmQtdEntrada { get; set; }
    }
}
