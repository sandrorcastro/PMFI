using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TipoBaixa
    {
        public TipoBaixa()
        {
            AtoBaixas = new HashSet<AtoBaixa>();
        }

        public int TipoBaixaId { get; set; }
        public string TipoBaixaNome { get; set; } = null!;
        public int? TbcodTribunal { get; set; }

        public virtual ICollection<AtoBaixa> AtoBaixas { get; set; }
    }
}
