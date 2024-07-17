using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegFormularioTipo
{
    public short IdFormTipo { get; set; }

    public string? NmFormTipo { get; set; }

    public virtual ICollection<TbSegFormulario> TbSegFormularios { get; set; } = new List<TbSegFormulario>();
}
