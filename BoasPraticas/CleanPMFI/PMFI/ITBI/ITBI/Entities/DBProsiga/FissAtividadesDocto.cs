using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FissAtividadesDocto
{
    public string Atividade { get; set; } = null!;

    public int DocId { get; set; }

    public string? AtDoObs { get; set; }

    public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;

    public virtual Documento Doc { get; set; } = null!;
}
