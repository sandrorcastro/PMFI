using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Numeracao
{
    public int IdNumeracao { get; set; }

    public int Sequencial { get; set; }

    public int? Ano { get; set; }

    public int IdSerie { get; set; }

    public int? IdOrgao { get; set; }

    public int? IdUnidade { get; set; }

    public virtual Orgao? IdOrgaoNavigation { get; set; }

    public virtual Serie IdSerieNavigation { get; set; } = null!;

    public virtual Unidade? IdUnidadeNavigation { get; set; }
}
