using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribDividasContribuinteProcesso
{
    /// <summary>
    /// Código de Identificação do Processo
    /// </summary>
    public long ProcId { get; set; }

    public long ConIddivida { get; set; }

    public string? BoleNossoNumero { get; set; }

    public virtual TribDividasContribuinte ConIddividaNavigation { get; set; } = null!;

    public virtual Processo Proc { get; set; } = null!;
}
