using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerContaCorrenteFonte
    {
        public int IdCcfonte { get; set; }
        public int? IdCcempresa { get; set; }
        public int? IdFonte { get; set; }
        public string? CdFonte { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
    }
}
