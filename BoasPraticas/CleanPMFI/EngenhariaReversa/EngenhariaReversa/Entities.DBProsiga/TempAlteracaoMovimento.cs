using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TempAlteracaoMovimento
    {
        public int? SituacaoId { get; set; }
        public int? SituacaoIdanterior { get; set; }
        public DateTime? Movdata { get; set; }
        public long Emprcmc { get; set; }
    }
}
