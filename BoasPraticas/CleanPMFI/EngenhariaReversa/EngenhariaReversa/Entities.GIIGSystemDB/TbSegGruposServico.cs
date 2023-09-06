using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegGruposServico
    {
        public TbSegGruposServico()
        {
            TbSegFormularios = new HashSet<TbSegFormulario>();
        }

        public short IdGrupoServico { get; set; }
        public string? NmGrupoServico { get; set; }

        public virtual ICollection<TbSegFormulario> TbSegFormularios { get; set; }
    }
}
