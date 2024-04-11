using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtiSetoresServidore
{
    public int IdSetor { get; set; }

    public int IdServidor { get; set; }

    public short? NrNivel { get; set; }

    public virtual TbGerServidore IdServidorNavigation { get; set; } = null!;

    public virtual TbCtiSetore IdSetorNavigation { get; set; } = null!;
}
