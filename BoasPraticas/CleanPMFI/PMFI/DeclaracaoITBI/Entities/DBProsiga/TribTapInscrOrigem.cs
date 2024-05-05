using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTapInscrOrigem
{
    public int TaInId { get; set; }

    public long TapId { get; set; }

    public long? EdificacaoId { get; set; }

    public long? ConId { get; set; }

    public long? EmprCmc { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual TribTap Tap { get; set; } = null!;
}
