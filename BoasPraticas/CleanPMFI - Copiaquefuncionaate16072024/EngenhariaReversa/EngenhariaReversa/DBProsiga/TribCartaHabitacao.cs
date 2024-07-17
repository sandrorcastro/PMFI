using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCartaHabitacao
    {
        public TribCartaHabitacao()
        {
            TribCartaHabitacaoAlvaraConstrs = new HashSet<TribCartaHabitacaoAlvaraConstr>();
            Procs = new HashSet<Processo>();
        }

        public long Idcarta { get; set; }
        public DateTime? DataEmissao { get; set; }
        public long? IdparamAssinatura { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<TribCartaHabitacaoAlvaraConstr> TribCartaHabitacaoAlvaraConstrs { get; set; }

        public virtual ICollection<Processo> Procs { get; set; }
    }
}
