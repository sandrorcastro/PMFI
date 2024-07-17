using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAlvaraRenovacao
    {
        public TribAlvaraRenovacao()
        {
            FzcredenciamentoAte201103s = new HashSet<FzcredenciamentoAte201103>();
        }

        public int RenovaId { get; set; }
        public string? RenoTipoAlvara { get; set; }
        public long? AlvaraId { get; set; }
        public DateTime? RenoDataInicial { get; set; }
        public DateTime? RenoDataFinal { get; set; }

        public virtual TribAlvaraEmpresa? Alvara { get; set; }
        public virtual ICollection<FzcredenciamentoAte201103> FzcredenciamentoAte201103s { get; set; }
    }
}
