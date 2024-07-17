using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTipoContrapartidaOpCredito
{
    public int IdTipoContraPartidaOpCredito { get; set; }

    public string? DsTipoContraPartidaOpCredito { get; set; }

    public virtual ICollection<TbFinContrapartidasOpCredito> TbFinContrapartidasOpCreditos { get; set; } = new List<TbFinContrapartidasOpCredito>();
}
