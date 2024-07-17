using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaIndicadoresAvaliacoesAno
    {
        public int IdIndicador { get; set; }
        public short NrAno { get; set; }
        public decimal? NrMedidaRealizada { get; set; }

        public virtual TbPlaIndicadore IdIndicadorNavigation { get; set; } = null!;
    }
}
