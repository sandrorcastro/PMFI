using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TbParametrosProcesso
    {
        public int IdParametro { get; set; }
        public string? NmParametro { get; set; }
        public int? IdAssunto { get; set; }
        public int? IdPrioridade { get; set; }
        public int? IdUnidadePadrao { get; set; }
    }
}
