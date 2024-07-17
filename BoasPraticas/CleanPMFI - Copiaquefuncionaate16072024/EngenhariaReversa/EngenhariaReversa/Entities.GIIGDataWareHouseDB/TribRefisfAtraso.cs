using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribRefisfAtraso
    {
        public int? NrTap { get; set; }
        public string? DsTipoCadastro { get; set; }
        public int? NrParcelas { get; set; }
        public int? NrParcelasEmAtraso { get; set; }
        public int? IdLei { get; set; }
    }
}
