using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcFunco
    {
        public TbOrcFunco()
        {
            TbOrcProgramasAcos = new HashSet<TbOrcProgramasAco>();
        }

        public short NrAno { get; set; }
        public string CdFuncao { get; set; } = null!;
        public string? DsFuncao { get; set; }

        public virtual ICollection<TbOrcProgramasAco> TbOrcProgramasAcos { get; set; }
    }
}
