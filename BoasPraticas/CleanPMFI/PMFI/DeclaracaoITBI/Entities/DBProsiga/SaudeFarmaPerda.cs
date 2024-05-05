using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeFarmaPerda
{
    public long Idperda { get; set; }

    public DateTime? Data { get; set; }

    public string? Hora { get; set; }

    public long? IdEstoque { get; set; }

    public string? Usuario { get; set; }

    public virtual ICollection<SaudeFarmaPerdaIten> SaudeFarmaPerdaItens { get; set; } = new List<SaudeFarmaPerdaIten>();

    public virtual ICollection<SaudeFarmaPerdaItensEstorno> SaudeFarmaPerdaItensEstornos { get; set; } = new List<SaudeFarmaPerdaItensEstorno>();
}
