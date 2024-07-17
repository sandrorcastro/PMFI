using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtiPergunta
{
    public int IdPergunta { get; set; }

    public int IdQuestionario { get; set; }

    public string? DsPergunta { get; set; }

    public virtual TbCtiQuestionario IdQuestionarioNavigation { get; set; } = null!;

    public virtual ICollection<TbCtiResposta> TbCtiResposta { get; set; } = new List<TbCtiResposta>();
}
