using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Psiaplicativo
    {
        public Psiaplicativo()
        {
            Psimodulos = new HashSet<Psimodulo>();
        }

        public long AplicativoId { get; set; }
        public string? AplicNome { get; set; }
        public string? AplicSigla { get; set; }

        public virtual ICollection<Psimodulo> Psimodulos { get; set; }
    }
}
