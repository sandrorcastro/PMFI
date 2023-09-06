using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerEmpresasGoverno
    {
        public short IdEmpresa { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? CdTce { get; set; }
    }
}
