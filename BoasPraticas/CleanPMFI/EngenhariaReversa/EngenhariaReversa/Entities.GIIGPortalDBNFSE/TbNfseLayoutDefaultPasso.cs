using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbNfseLayoutDefaultPasso
    {
        public int IdLayoutDefaultPassos { get; set; }
        public int? IdSistema { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrOrdem { get; set; }
        public string? DsTituloPasso { get; set; }
        public string? DsPasso { get; set; }
        public byte[]? BnImagem { get; set; }
        public string? NmImagem { get; set; }
        public string? DsExtensaoImagem { get; set; }
    }
}
