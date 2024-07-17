using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcSubFunco
    {
        public TbOrcSubFunco()
        {
            TbOrcProgramasAcos = new HashSet<TbOrcProgramasAco>();
        }

        public short NrAno { get; set; }
        public string CdSubFuncao { get; set; } = null!;
        public string? DsSubFuncao { get; set; }

        public virtual ICollection<TbOrcProgramasAco> TbOrcProgramasAcos { get; set; }
    }
}
