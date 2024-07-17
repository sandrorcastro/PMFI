using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegFormularioTipo
    {
        public TbSegFormularioTipo()
        {
            TbSegFormularios = new HashSet<TbSegFormulario>();
        }

        public short IdFormTipo { get; set; }
        public string? NmFormTipo { get; set; }

        public virtual ICollection<TbSegFormulario> TbSegFormularios { get; set; }
    }
}
