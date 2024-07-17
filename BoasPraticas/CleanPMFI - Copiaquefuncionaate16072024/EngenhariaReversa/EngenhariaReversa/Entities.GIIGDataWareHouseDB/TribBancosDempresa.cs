using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribBancosDempresa
    {
        public int? NrCme { get; set; }
        public string? NrCpfcnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public short? IdBanco { get; set; }
        public string? DsEndereco { get; set; }
    }
}
