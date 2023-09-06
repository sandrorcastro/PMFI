using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class DEmpresa
    {
        public int IdEmpresa { get; set; }
        public string? DsCme { get; set; }
        public string? DsCpfcnpj { get; set; }
        public string? DsNomeFantasia { get; set; }
    }
}
