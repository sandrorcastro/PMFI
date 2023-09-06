using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribNfsehomologadadEmpresa
    {
        public int? IdEmpresa { get; set; }
        public string? NrCmc { get; set; }
        public string? DsCnpjcpf { get; set; }
        public string? DsRazaoSocial { get; set; }
        public DateTime? DtHomologado { get; set; }
        public int? IdRegime { get; set; }
    }
}
