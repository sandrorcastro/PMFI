using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbStnMarcador
    {
        public TbStnMarcador()
        {
            CdFontePadraoStns = new HashSet<TbStnFontePadrao>();
        }

        public string CdMarcadorStn { get; set; } = null!;
        public string? DsMarcadorStn { get; set; }
        public string? DsEspecificação { get; set; }

        public virtual ICollection<TbStnFontePadrao> CdFontePadraoStns { get; set; }
    }
}
