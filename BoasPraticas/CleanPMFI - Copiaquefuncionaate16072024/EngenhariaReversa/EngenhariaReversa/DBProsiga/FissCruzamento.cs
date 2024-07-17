using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissCruzamento
    {
        public int FissCruzId { get; set; }
        public string? FissCruzNome { get; set; }
        public string? FissCruzDescricao { get; set; }
        public int? TipoOpId { get; set; }

        public virtual FissTipoOperacao? TipoOp { get; set; }
    }
}
