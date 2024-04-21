using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasRisco
{
    public int Idempresarisco { get; set; }

    public int? EmprCmc { get; set; }

    public string Nrprotocolo { get; set; } = null!;

    public string Atividade { get; set; } = null!;

    public int Idsetor { get; set; }

    public int Idrisco { get; set; }

    public string? Nrperguntajunta { get; set; }

    public string? Dsresposta { get; set; }

    public int? Idpergunta { get; set; }

    public int? Idresposta { get; set; }

    /// <summary>
    /// Indica se a Atividade está sendo incluida por este PRP na empresa
    /// </summary>
    public string Flinclusaocnae { get; set; } = null!;
}
