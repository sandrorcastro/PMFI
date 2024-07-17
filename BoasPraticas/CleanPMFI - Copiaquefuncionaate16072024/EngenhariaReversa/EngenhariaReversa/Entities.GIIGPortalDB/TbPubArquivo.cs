using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubArquivo
    {
        public int IdArquivo { get; set; }
        public string? DsArquivo { get; set; }
        public string? DsNomeArquivo { get; set; }
        public string? DsExtensaoArquivo { get; set; }
        public byte[]? BnArquivo { get; set; }
        public short? NrMesCompetencia { get; set; }
        public short? NrAnoCompetencia { get; set; }
        public DateTime? DtPublicacao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TbPubCategoria? IdCategoriaNavigation { get; set; }
    }
}
