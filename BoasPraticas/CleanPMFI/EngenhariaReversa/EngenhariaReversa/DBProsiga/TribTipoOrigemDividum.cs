using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoOrigemDividum
    {
        public TribTipoOrigemDividum()
        {
            TribOrigemDivida = new HashSet<TribOrigemDividum>();
        }

        public int TribTipoId { get; set; }
        public string? TribTipoNome { get; set; }
        public string? TribTipoSigla { get; set; }
        public string? PossuiEdital { get; set; }

        public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; }
    }
}
