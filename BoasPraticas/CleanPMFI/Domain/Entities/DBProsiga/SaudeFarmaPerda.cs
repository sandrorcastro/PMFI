using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeFarmaPerda
    {
        public SaudeFarmaPerda()
        {
            SaudeFarmaPerdaItens = new HashSet<SaudeFarmaPerdaIten>();
            SaudeFarmaPerdaItensEstornos = new HashSet<SaudeFarmaPerdaItensEstorno>();
        }

        public long Idperda { get; set; }
        public DateTime? Data { get; set; }
        public string? Hora { get; set; }
        public long? IdEstoque { get; set; }
        public string? Usuario { get; set; }

        public virtual ICollection<SaudeFarmaPerdaIten> SaudeFarmaPerdaItens { get; set; }
        public virtual ICollection<SaudeFarmaPerdaItensEstorno> SaudeFarmaPerdaItensEstornos { get; set; }
    }
}
