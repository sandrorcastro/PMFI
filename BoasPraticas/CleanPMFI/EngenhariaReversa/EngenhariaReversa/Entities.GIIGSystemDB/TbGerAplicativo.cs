using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbGerAplicativo
    {
        public TbGerAplicativo()
        {
            DsLogins = new HashSet<TbSegUsuario>();
        }

        public int IdAplicativo { get; set; }
        public string? DsTitulo { get; set; }
        public string? DsModulo { get; set; }
        public short? NrHeigth { get; set; }
        public string? DsLink { get; set; }
        public short? IdModulo { get; set; }

        public virtual TbSegModulo? IdModuloNavigation { get; set; }

        public virtual ICollection<TbSegUsuario> DsLogins { get; set; }
    }
}
