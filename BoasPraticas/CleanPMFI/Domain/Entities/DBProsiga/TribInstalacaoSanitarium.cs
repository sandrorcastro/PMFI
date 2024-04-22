using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribInstalacaoSanitarium
    {
        public TribInstalacaoSanitarium()
        {
            TribEdifInstSanitaria = new HashSet<TribEdifInstSanitarium>();
        }

        public int InstSanitId { get; set; }
        public string? InstSanitNome { get; set; }
        public decimal? InstSanitFator { get; set; }
        public int? InstSanitPontos { get; set; }

        public virtual ICollection<TribEdifInstSanitarium> TribEdifInstSanitaria { get; set; }
    }
}
