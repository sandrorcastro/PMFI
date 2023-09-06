using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegEmpresasGoverno
    {
        public TbSegEmpresasGoverno()
        {
            TbSegUsuarios = new HashSet<TbSegUsuario>();
            TbSegUsuariosEmpresasModulos = new HashSet<TbSegUsuariosEmpresasModulo>();
        }

        public short IdEmpresa { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmEmpresa { get; set; }
        public string? DsTipo { get; set; }

        public virtual ICollection<TbSegUsuario> TbSegUsuarios { get; set; }
        public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; }
    }
}
