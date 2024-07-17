using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscReclamacaoTpReclamacao
{
    public int RecTpRecId { get; set; }

    public int? TipoRecId { get; set; }

    public long? ReclId { get; set; }
}
