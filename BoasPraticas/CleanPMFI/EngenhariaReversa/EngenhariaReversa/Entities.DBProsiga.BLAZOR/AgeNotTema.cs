using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AgeNotTema
    {
        public AgeNotTema()
        {
            AgeNotNoticia = new HashSet<AgeNotNoticia>();
        }

        public int TemaId { get; set; }
        public string? TemaDescricao { get; set; }

        public virtual ICollection<AgeNotNoticia> AgeNotNoticia { get; set; }
    }
}
