using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class GccTipoCreche
    {
        public GccTipoCreche()
        {
            GccCreches = new HashSet<GccCreche>();
        }

        public string TcreCnpjmembro { get; set; } = null!;
        public int TcreId { get; set; }
        public string? TcreDescr { get; set; }

        public virtual ICollection<GccCreche> GccCreches { get; set; }
    }
}
