using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribReducaoTributosItensDivida
{
    public int IdReducaoTributoItemDivida { get; set; }

    public int IdReducaoTributo { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIdDivida { get; set; }

    public virtual TribReducaoTributosIten IdReducaoTributoNavigation { get; set; } = null!;
}
