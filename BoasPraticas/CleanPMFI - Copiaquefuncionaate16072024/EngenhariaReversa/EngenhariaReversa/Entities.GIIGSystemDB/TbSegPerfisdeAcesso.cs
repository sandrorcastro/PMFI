using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegPerfisdeAcesso
    {
        public TbSegPerfisdeAcesso()
        {
            TbSegPerfisdeAcessoFormularios = new HashSet<TbSegPerfisdeAcessoFormulario>();
            TbSegUsuariosEmpresasModulos = new HashSet<TbSegUsuariosEmpresasModulo>();
        }

        public short IdPerfilAcesso { get; set; }
        public string? NmPerfilAcesso { get; set; }
        public short? IdModulo { get; set; }
        public bool? FlAdmin { get; set; }

        public virtual TbSegModulo? IdModuloNavigation { get; set; }
        public virtual ICollection<TbSegPerfisdeAcessoFormulario> TbSegPerfisdeAcessoFormularios { get; set; }
        public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; }
    }
}
