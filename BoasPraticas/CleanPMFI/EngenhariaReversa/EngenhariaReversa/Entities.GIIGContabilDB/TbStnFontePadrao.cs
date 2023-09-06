using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbStnFontePadrao
    {
        public TbStnFontePadrao()
        {
            CdMarcadorStns = new HashSet<TbStnMarcador>();
        }

        public int CdFontePadraoStn { get; set; }
        public string? DsFontePadraoStn { get; set; }
        public string? DsEspecificação { get; set; }

        public virtual ICollection<TbStnMarcador> CdMarcadorStns { get; set; }
    }
}
