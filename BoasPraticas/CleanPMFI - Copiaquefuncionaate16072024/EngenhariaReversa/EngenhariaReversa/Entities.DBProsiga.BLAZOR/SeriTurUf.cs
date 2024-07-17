using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SeriTurUf
    {
        public SeriTurUf()
        {
            IdmovOrigems = new HashSet<SeriTurOrigemTuristaCidadao>();
        }

        public long Iduf { get; set; }
        public string? Ufnome { get; set; }
        public string? Regiao { get; set; }
        public long? Idpais { get; set; }

        public virtual ICollection<SeriTurOrigemTuristaCidadao> IdmovOrigems { get; set; }
    }
}
