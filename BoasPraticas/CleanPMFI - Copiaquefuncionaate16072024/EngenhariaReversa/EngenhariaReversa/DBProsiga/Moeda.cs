using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Moeda
    {
        public Moeda()
        {
            MoedasReferencia = new HashSet<MoedasReferencia>();
            TribAutosInfracaos = new HashSet<TribAutosInfracao>();
            TribCoeficienteTaxasIptus = new HashSet<TribCoeficienteTaxasIptu>();
        }

        public short Idmoeda { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public virtual ICollection<MoedasReferencia> MoedasReferencia { get; set; }
        public virtual ICollection<TribAutosInfracao> TribAutosInfracaos { get; set; }
        public virtual ICollection<TribCoeficienteTaxasIptu> TribCoeficienteTaxasIptus { get; set; }
    }
}
