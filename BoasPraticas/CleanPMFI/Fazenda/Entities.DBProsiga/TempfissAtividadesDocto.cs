using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TempfissAtividadesDocto
{
    public string Atividade { get; set; } = null!;

    public int DocId { get; set; }

    public string? AtDoObs { get; set; }
}
