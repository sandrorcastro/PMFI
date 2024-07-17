using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class WflowRequisicao
    {
        public WflowRequisicao()
        {
            WflowRemessas = new HashSet<WflowRemessa>();
            WflowRequisicaoItens = new HashSet<WflowRequisicaoIten>();
        }

        public long RequiId { get; set; }
        public string? RequiJust { get; set; }
        public string? RequiSolicitante { get; set; }
        public DateTime? RequiData { get; set; }

        public virtual ICollection<WflowRemessa> WflowRemessas { get; set; }
        public virtual ICollection<WflowRequisicaoIten> WflowRequisicaoItens { get; set; }
    }
}
