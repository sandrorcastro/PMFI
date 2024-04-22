using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissTipoOperacao
    {
        public FissTipoOperacao()
        {
            FissCruzamentos = new HashSet<FissCruzamento>();
            FissMovims = new HashSet<FissMovim>();
            FissTomadorPrestadors = new HashSet<FissTomadorPrestador>();
        }

        public int TipoOpId { get; set; }
        public string? TipoOpNome { get; set; }
        public string? TipoOpGravaMov { get; set; }

        public virtual ICollection<FissCruzamento> FissCruzamentos { get; set; }
        public virtual ICollection<FissMovim> FissMovims { get; set; }
        public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; }
    }
}
