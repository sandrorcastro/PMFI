using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribRecolhimentoBlocosNf
{
    public long RecNfid { get; set; }

    public int? AutNfid { get; set; }

    public DateTime? RecNfdataRec { get; set; }

    public string? RecNfrecPorPessoa { get; set; }

    public DateTime? RecNfdataDevol { get; set; }

    public string? RecNfdevolApessoa { get; set; }

    public string? RecNfobservacao { get; set; }

    public virtual TribAutorizacaoBlocosNf? AutNf { get; set; }
}
