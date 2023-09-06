using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaLocalizadore
    {
        public TbPlaLocalizadore()
        {
            TbPlaObjetivosMetasLocalizadores = new HashSet<TbPlaObjetivosMetasLocalizadore>();
        }

        public int IdLocalizador { get; set; }
        public string? NmLocalizador { get; set; }

        public virtual ICollection<TbPlaObjetivosMetasLocalizadore> TbPlaObjetivosMetasLocalizadores { get; set; }
    }
}
