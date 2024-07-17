using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SocComposicaoPasse
    {
        public long CompId { get; set; }
        public long? PasseId { get; set; }
        public long? ConId { get; set; }
        public string? CompTipo { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual SocPasse? Passe { get; set; }
    }
}
