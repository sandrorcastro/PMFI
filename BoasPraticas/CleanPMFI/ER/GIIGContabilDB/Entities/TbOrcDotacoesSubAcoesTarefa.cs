using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcDotacoesSubAcoesTarefa
{
    public int Iddotacao { get; set; }

    public int IdSubAcaoTarefa { get; set; }

    public decimal? VlOrcado { get; set; }

    public decimal? VlDisponivel { get; set; }

    public virtual TbOrcSubAcoesTarefa IdSubAcaoTarefaNavigation { get; set; } = null!;

    public virtual TbOrcDotaco IddotacaoNavigation { get; set; } = null!;
}
