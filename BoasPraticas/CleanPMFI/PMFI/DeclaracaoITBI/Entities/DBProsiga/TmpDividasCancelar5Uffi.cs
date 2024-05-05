using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TmpDividasCancelar5Uffi
{
    public string Cadastro { get; set; } = null!;

    public string? ConCnpjcpf { get; set; }

    public string? ConNome { get; set; }

    public long IdDivida { get; set; }

    public long? IdInscricao { get; set; }

    public int TipoTribId { get; set; }

    public string? TipoTribNome { get; set; }

    public int? Ano { get; set; }

    public decimal Valor { get; set; }

    public decimal? ValorCorrigido { get; set; }
}
