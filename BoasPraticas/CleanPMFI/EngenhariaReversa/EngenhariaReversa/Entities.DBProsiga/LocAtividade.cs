using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class LocAtividade
    {
        public LocAtividade()
        {
            LocFilaEsperas = new HashSet<LocFilaEspera>();
            Locacaos = new HashSet<Locacao>();
        }

        public int AtividadeId { get; set; }
        public string? AtivDescricao { get; set; }
        public string? AtivTecUltAlt { get; set; }
        public DateTime? AtivDtUltAlt { get; set; }

        public virtual ICollection<LocFilaEspera> LocFilaEsperas { get; set; }
        public virtual ICollection<Locacao> Locacaos { get; set; }
    }
}
