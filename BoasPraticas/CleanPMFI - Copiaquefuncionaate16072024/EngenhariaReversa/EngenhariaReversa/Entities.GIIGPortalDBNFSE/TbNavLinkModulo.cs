using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbNavLinkModulo
    {
        public TbNavLinkModulo()
        {
            TbNavLinkItens = new HashSet<TbNavLinkIten>();
        }

        public int IdLinkModulo { get; set; }
        public string? NmLinkModulo { get; set; }
        public string? FlExibiMapa { get; set; }
        public string? FlVisivel { get; set; }
        public string? FlVerificaAutenticacao { get; set; }
        public short? NrOrdem { get; set; }
        public short? IdEmpresa { get; set; }
        public short? IdSistema { get; set; }

        public virtual ICollection<TbNavLinkIten> TbNavLinkItens { get; set; }
    }
}
