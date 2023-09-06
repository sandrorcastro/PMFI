using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbGerTipoContato
    {
        public int IdTipoContato { get; set; }
        public string? DsTipoContato { get; set; }
        public string? DsEmail { get; set; }
        public int? NrEnvios { get; set; }
        public short? IdEmpresa { get; set; }
        public short? IdSistema { get; set; }
    }
}
