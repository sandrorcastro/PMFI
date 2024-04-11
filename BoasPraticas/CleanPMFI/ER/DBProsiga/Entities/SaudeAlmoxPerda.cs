using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAlmoxPerda
{
    public long Idperda { get; set; }

    public DateTime? Data { get; set; }

    public string? Hora { get; set; }

    public long? IdAlmox { get; set; }

    public virtual ICollection<SaudeAlmoxPerdaIten> SaudeAlmoxPerdaItens { get; set; } = new List<SaudeAlmoxPerdaIten>();

    public virtual ICollection<SaudeAlmoxPerdaItensExtorno> SaudeAlmoxPerdaItensExtornos { get; set; } = new List<SaudeAlmoxPerdaItensExtorno>();
}
