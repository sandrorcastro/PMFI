using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Psiobjeto
{
    public long ObjetoId { get; set; }

    public string? ObjNome { get; set; }

    public string? ObjTipo { get; set; }

    public byte[]? Objeto { get; set; }

    public DateTime? ObjDtCad { get; set; }

    public string? ObjUsuarioCad { get; set; }

    public virtual ICollection<Psiformulario> PsiformularioFormCabecObjs { get; set; } = new List<Psiformulario>();

    public virtual ICollection<Psiformulario> PsiformularioFormHelpObjs { get; set; } = new List<Psiformulario>();

    public virtual ICollection<Psitema> PsitemaTemaCabecObjs { get; set; } = new List<Psitema>();

    public virtual ICollection<Psitema> PsitemaTemaRodapeobjs { get; set; } = new List<Psitema>();
}
