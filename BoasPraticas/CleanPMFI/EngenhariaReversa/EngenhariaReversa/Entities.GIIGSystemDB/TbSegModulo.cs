using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegModulo
    {
        public TbSegModulo()
        {
            TbGerAplicativos = new HashSet<TbGerAplicativo>();
            TbSegFormularios = new HashSet<TbSegFormulario>();
            TbSegPerfisdeAcessos = new HashSet<TbSegPerfisdeAcesso>();
            TbSegUsuariosEmpresasModulos = new HashSet<TbSegUsuariosEmpresasModulo>();
        }

        public short IdModulo { get; set; }
        public string? NmModulo { get; set; }
        public string? DsModulo { get; set; }
        public short? NrOrdem { get; set; }
        public bool? FlMostrarLogin { get; set; }

        public virtual ICollection<TbGerAplicativo> TbGerAplicativos { get; set; }
        public virtual ICollection<TbSegFormulario> TbSegFormularios { get; set; }
        public virtual ICollection<TbSegPerfisdeAcesso> TbSegPerfisdeAcessos { get; set; }
        public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; }
    }
}
