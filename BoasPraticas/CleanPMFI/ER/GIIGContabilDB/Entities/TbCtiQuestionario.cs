using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtiQuestionario
{
    public int IdQuestionario { get; set; }

    public int IdAssunto { get; set; }

    public string? DsQuestionario { get; set; }

    public string? DsResultadoEsperado { get; set; }

    public virtual TbCtiAssunto IdAssuntoNavigation { get; set; } = null!;

    public virtual ICollection<TbCtiDespachoSetor> TbCtiDespachoSetors { get; set; } = new List<TbCtiDespachoSetor>();

    public virtual ICollection<TbCtiPergunta> TbCtiPergunta { get; set; } = new List<TbCtiPergunta>();
}
