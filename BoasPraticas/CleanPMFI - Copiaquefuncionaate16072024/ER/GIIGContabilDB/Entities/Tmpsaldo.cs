using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tmpsaldo
{
    public short IdEmpresa { get; set; }

    public int? Ano { get; set; }

    public int? CdEvento { get; set; }

    public string Data { get; set; } = null!;

    public decimal? VlLancamento { get; set; }

    public string Dshistorico { get; set; } = null!;

    public string? DsOperacao { get; set; }

    public string Objeto { get; set; } = null!;

    public int? Id { get; set; }

    public int Processado { get; set; }

    public int? Orgao { get; set; }

    public int? Unidade { get; set; }

    public string Usuario { get; set; } = null!;

    public string Ip { get; set; } = null!;
}
