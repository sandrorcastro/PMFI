using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubFonteDado
    {
        public TbPubFonteDado()
        {
            TbPubFonteDadosFiltros = new HashSet<TbPubFonteDadosFiltro>();
            TbPubVisaoFonteDados = new HashSet<TbPubVisaoFonteDado>();
        }

        public int IdFonteDados { get; set; }
        public string? NmFonteDados { get; set; }
        public string? NmTemporyTable { get; set; }
        public string? DsFonteDados { get; set; }
        public string? NmProvider { get; set; }
        public short? NrDiasAtualizacao { get; set; }

        public virtual ICollection<TbPubFonteDadosFiltro> TbPubFonteDadosFiltros { get; set; }
        public virtual ICollection<TbPubVisaoFonteDado> TbPubVisaoFonteDados { get; set; }
    }
}
