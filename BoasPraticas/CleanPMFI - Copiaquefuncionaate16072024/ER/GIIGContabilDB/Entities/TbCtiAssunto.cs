using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtiAssunto
{
    public int IdAssunto { get; set; }

    public string? DsTitulo { get; set; }

    public string? DsAssunto { get; set; }

    public virtual ICollection<TbCtiQuestionario> TbCtiQuestionarios { get; set; } = new List<TbCtiQuestionario>();
}
