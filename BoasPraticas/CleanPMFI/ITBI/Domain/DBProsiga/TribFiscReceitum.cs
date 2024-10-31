using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscReceitum
    {
        public TribFiscReceitum()
        {
            TribFiscReceitaItems = new HashSet<TribFiscReceitaItem>();
            Prots = new HashSet<TribFiscProtocolo>();
        }

        public int RecId { get; set; }
        public long IdtipoProcFiscal { get; set; }
        public int? RecNumero { get; set; }
        public long? EmprCmc { get; set; }
        public string? Paciente { get; set; }

        public virtual ICollection<TribFiscReceitaItem> TribFiscReceitaItems { get; set; }

        public virtual ICollection<TribFiscProtocolo> Prots { get; set; }
    }
}
