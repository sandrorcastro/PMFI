using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class EduformacaoContribuinte
{
    public long ConId { get; set; }

    public long FormId { get; set; }

    /// <summary>
    /// Data da Formação
    /// </summary>
    public DateTime? FormContData { get; set; }

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual Eduformacao Form { get; set; } = null!;
}
