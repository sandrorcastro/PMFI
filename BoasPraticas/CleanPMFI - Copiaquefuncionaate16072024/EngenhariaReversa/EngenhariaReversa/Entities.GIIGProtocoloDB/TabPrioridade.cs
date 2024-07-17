using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabPrioridade
    {
        public TabPrioridade()
        {
            TabProcessos = new HashSet<TabProcesso>();
        }

        public byte PrioId { get; set; }
        public string? PrioNome { get; set; }
        public string? PrioPadrao { get; set; }
        public string? PrioCor { get; set; }

        public virtual ICollection<TabProcesso> TabProcessos { get; set; }
    }
}
