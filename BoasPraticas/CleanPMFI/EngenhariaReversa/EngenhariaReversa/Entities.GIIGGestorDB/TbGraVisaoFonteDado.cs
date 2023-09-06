using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbGraVisaoFonteDado
    {
        public TbGraVisaoFonteDado()
        {
            TbGraGraficos = new HashSet<TbGraGrafico>();
        }

        public int IdVisao { get; set; }
        public string? NmVisao { get; set; }
        public int IdFonteDados { get; set; }
        public string? DsQuery { get; set; }

        public virtual TbGraFonteDado IdFonteDadosNavigation { get; set; } = null!;
        public virtual ICollection<TbGraGrafico> TbGraGraficos { get; set; }
    }
}
