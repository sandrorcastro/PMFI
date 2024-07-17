using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbGraFonteDado
    {
        public TbGraFonteDado()
        {
            TbGraVisaoFonteDados = new HashSet<TbGraVisaoFonteDado>();
        }

        public int IdFonteDados { get; set; }
        public string? NmFonteDados { get; set; }
        public string? NmTemporyTable { get; set; }
        public string? DsFonteDados { get; set; }
        public string? NmProvider { get; set; }

        public virtual ICollection<TbGraVisaoFonteDado> TbGraVisaoFonteDados { get; set; }
    }
}
