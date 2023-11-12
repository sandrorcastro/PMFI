using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscVistoriaItensVistoriadosNota
{
    public long IdnotaVist { get; set; }

    public int? VistId { get; set; }

    public int? ItemVistId { get; set; }

    public long? Nfid { get; set; }

    public long? Nfidorigem { get; set; }

    public string? Nfsistema { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? NftipoForm { get; set; }
}
