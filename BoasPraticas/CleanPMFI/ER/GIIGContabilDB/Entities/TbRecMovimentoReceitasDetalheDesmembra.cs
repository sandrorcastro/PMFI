using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecMovimentoReceitasDetalheDesmembra
{
    /// <summary>
    /// Código para identificar exclusivamente o registro.
    /// </summary>
    public int IdDetalheMovReceita { get; set; }

    public int IdFonte { get; set; }

    public string? CdContaContabilDisponivel { get; set; }

    public decimal? VlLancado { get; set; }

    public decimal? VlPercentual { get; set; }

    public virtual TbRecMovimentoReceitasDetalhe IdDetalheMovReceitaNavigation { get; set; } = null!;

    public virtual TbOrcFonte IdFonteNavigation { get; set; } = null!;
}
