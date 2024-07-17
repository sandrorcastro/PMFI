using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class GrupoContribuinteConcessaoImovei
    {
        public long IdContratoConcessao { get; set; }
        public long ConId { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
    }
}
