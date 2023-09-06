using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TabLogAtualizacao
    {
        public int IdLog { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public string? DsObservacao { get; set; }
        public bool? FlAtualizado { get; set; }
    }
}
