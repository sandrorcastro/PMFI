using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcProgramasAcoesLoaSubAcoesTarefa
    {
        public int IdRegistro { get; set; }
        public int? IdAcaoLoa { get; set; }
        public int? IdSubAcaoTarefa { get; set; }
        public decimal? VlOrcado { get; set; }

        public virtual TbOrcProgramasAcoesLoa? IdAcaoLoaNavigation { get; set; }
        public virtual TbOrcSubAcoesTarefa? IdSubAcaoTarefaNavigation { get; set; }
    }
}
