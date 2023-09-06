using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribCalculoSimulado
    {
        public TribCalculoSimulado()
        {
            TribCalculoSimuladoLancs = new HashSet<TribCalculoSimuladoLanc>();
        }

        public int SimuId { get; set; }
        public string? SimuDescricao { get; set; }
        public DateTime? SimuData { get; set; }
        public string? SimuPasta { get; set; }
        public short? SimuAno { get; set; }

        public virtual ICollection<TribCalculoSimuladoLanc> TribCalculoSimuladoLancs { get; set; }
    }
}
