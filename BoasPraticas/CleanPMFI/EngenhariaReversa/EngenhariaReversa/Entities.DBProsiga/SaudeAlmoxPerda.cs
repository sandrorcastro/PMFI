using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeAlmoxPerda
    {
        public SaudeAlmoxPerda()
        {
            SaudeAlmoxPerdaItens = new HashSet<SaudeAlmoxPerdaIten>();
            SaudeAlmoxPerdaItensExtornos = new HashSet<SaudeAlmoxPerdaItensExtorno>();
        }

        public long Idperda { get; set; }
        public DateTime? Data { get; set; }
        public string? Hora { get; set; }
        public long? IdAlmox { get; set; }

        public virtual ICollection<SaudeAlmoxPerdaIten> SaudeAlmoxPerdaItens { get; set; }
        public virtual ICollection<SaudeAlmoxPerdaItensExtorno> SaudeAlmoxPerdaItensExtornos { get; set; }
    }
}
