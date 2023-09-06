using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SeriTurInformacoesPrestada
    {
        public long IdmovInform { get; set; }
        public long? IdmovOrigem { get; set; }
        public long? Qtde { get; set; }
        public long? IdtipoInfo { get; set; }
    }
}
