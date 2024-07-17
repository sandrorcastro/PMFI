using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribClassificaoReceitaDetalhadum
{
    public int DetId { get; set; }

    public DateTime ClreDataBaixa { get; set; }

    public string NossoNumero { get; set; } = null!;

    public int TipoTribId { get; set; }

    public string ClreReceita { get; set; } = null!;

    public int ConvenioId { get; set; }

    public string Classificando { get; set; } = null!;

    /// <summary>
    /// Valor da receita.
    /// </summary>
    public decimal ClreValor { get; set; }

    public long? ImoIddivida { get; set; }

    public long? EmpIddivida { get; set; }

    public long? ConIddivida { get; set; }
}
