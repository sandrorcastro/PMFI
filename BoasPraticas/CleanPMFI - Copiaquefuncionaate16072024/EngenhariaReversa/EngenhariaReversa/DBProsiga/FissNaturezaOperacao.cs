using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissNaturezaOperacao
    {
        public FissNaturezaOperacao()
        {
            FissDocFiscais = new HashSet<FissDocFiscai>();
        }

        public long NatOpId { get; set; }
        public string? NatOpDescricao { get; set; }
        public string? NatOpIsenta { get; set; }
        public string NatOpAlteraVlrServico { get; set; } = null!;

        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
    }
}
