using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEmpenhoEmailEnviado
    {
        public int IdNotificacao { get; set; }
        public int? IdEmpenho { get; set; }
        public DateTime? DtInclusao { get; set; }
    }
}
