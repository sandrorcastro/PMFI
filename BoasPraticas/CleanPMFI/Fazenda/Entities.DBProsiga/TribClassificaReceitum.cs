using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribClassificaReceitum
{
    public DateTime ClreDataBaixa { get; set; }

    public int TipoTribId { get; set; }

    public string ClreReceita { get; set; } = null!;

    public int ConvenioId { get; set; }

    public string ClreTipo { get; set; } = null!;

    public string IdBanco { get; set; } = null!;

    public short IdTipoOperacaoReceita { get; set; }

    /// <summary>
    /// Valor da receita.
    /// </summary>
    public decimal ClreValor { get; set; }

    public virtual ConvenioBanco Convenio { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
