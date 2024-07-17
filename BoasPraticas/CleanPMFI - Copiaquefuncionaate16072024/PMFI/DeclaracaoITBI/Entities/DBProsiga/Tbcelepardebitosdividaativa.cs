using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Tbcelepardebitosdividaativa
{
    public int Iddividaativa { get; set; }

    public short Tipodocumento { get; set; }

    public long Numdocumento { get; set; }

    public string Nomedevedor { get; set; } = null!;

    public DateOnly Dtinscricaoda { get; set; }

    public string Autoformatado { get; set; } = null!;

    public decimal Vlrnotificadodivida { get; set; }

    public DateOnly Dtvencimento { get; set; }

    public int Idintegracaomunicipio { get; set; }

    public DateOnly Dtinfracao { get; set; }

    public decimal? Vlrpagamento { get; set; }

    public DateOnly? Dtbaixapagamento { get; set; }

    public DateTime? Dtinclusao { get; set; }

    public int? Idusuarioinclusao { get; set; }

    /// <summary>
    /// ID do contribuinte que foi integrado a divida.
    /// </summary>
    public long? Conidintegrado { get; set; }

    public long? Coniddividaintegrado { get; set; }

    /// <summary>
    /// Indica se o contribuinte foi criado pela integração (Novo = S)
    /// </summary>
    public string? Flconidnovo { get; set; }
}
