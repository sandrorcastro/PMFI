using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Psiobjeto
    {
        public Psiobjeto()
        {
            PsiformularioFormCabecObjs = new HashSet<Psiformulario>();
            PsiformularioFormHelpObjs = new HashSet<Psiformulario>();
            PsitemaTemaCabecObjs = new HashSet<Psitema>();
            PsitemaTemaRodapeobjs = new HashSet<Psitema>();
        }

        public long ObjetoId { get; set; }
        public string? ObjNome { get; set; }
        public string? ObjTipo { get; set; }
        public byte[]? Objeto { get; set; }
        public DateTime? ObjDtCad { get; set; }
        public string? ObjUsuarioCad { get; set; }

        public virtual ICollection<Psiformulario> PsiformularioFormCabecObjs { get; set; }
        public virtual ICollection<Psiformulario> PsiformularioFormHelpObjs { get; set; }
        public virtual ICollection<Psitema> PsitemaTemaCabecObjs { get; set; }
        public virtual ICollection<Psitema> PsitemaTemaRodapeobjs { get; set; }
    }
}
