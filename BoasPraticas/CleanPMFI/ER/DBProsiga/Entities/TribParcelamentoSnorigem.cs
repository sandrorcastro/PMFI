using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribParcelamentoSnorigem
{
    public int ParcSnidorigem { get; set; }

    public int? ParcSnid { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }
}
