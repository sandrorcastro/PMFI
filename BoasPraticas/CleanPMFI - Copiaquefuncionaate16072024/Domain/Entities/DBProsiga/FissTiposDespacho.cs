using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissTiposDespacho
    {
        public FissTiposDespacho()
        {
            FissDespachosServidores = new HashSet<FissDespachosServidore>();
        }

        public long IdtipoDespacho { get; set; }
        public string? NomeDespacho { get; set; }

        public virtual ICollection<FissDespachosServidore> FissDespachosServidores { get; set; }
    }
}
