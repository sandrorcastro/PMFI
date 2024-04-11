using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcAtualizacoesMonetOrcamentoDotaco
{
    public int IdAtualizacao { get; set; }

    public int Iddotacao { get; set; }

    public decimal? VlCorrecao { get; set; }

    public virtual TbOrcAtualizacoesMonetariaOrcamento IdAtualizacaoNavigation { get; set; } = null!;

    public virtual TbOrcDotaco IddotacaoNavigation { get; set; } = null!;
}
