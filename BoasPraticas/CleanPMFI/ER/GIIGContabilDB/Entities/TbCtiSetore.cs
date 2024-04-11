using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtiSetore
{
    public int IdSetor { get; set; }

    public string? NmSetor { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public virtual ICollection<TbCtiDespachoSetor> TbCtiDespachoSetors { get; set; } = new List<TbCtiDespachoSetor>();

    public virtual ICollection<TbCtiSetoresServidore> TbCtiSetoresServidores { get; set; } = new List<TbCtiSetoresServidore>();
}
