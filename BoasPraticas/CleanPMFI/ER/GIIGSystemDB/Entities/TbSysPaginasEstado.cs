using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSysPaginasEstado
{
    public string IdPage { get; set; } = null!;

    public string? VsState { get; set; }

    public DateTime? DtAlteracao { get; set; }
}
