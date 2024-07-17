using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaUnidadeDividum
    {
        public int IdConsulta { get; set; }
        public int IdUnidade { get; set; }
        public long? IdDivida { get; set; }
    }
}
