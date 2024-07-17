using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbImoTipoArea
{
    public int IdtipoArea { get; set; }

    public string DsTipoArea { get; set; } = null!;

    public short CdTipoConta { get; set; }

    public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; } = new List<ImobensImovei>();
}
