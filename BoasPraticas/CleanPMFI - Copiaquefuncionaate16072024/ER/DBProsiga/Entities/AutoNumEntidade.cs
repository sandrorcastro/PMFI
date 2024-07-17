using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AutoNumEntidade
{
    /// <summary>
    /// Nome da entidade que utiliza o auto numeração.
    /// </summary>
    public string AutNumEntidade { get; set; } = null!;

    /// <summary>
    /// Auto numeração da entidade.
    /// </summary>
    public long AutNumId { get; set; }
}
