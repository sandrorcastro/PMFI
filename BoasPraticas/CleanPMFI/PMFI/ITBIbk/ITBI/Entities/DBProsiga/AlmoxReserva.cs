using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmoxReserva
{
    public long AlmoxId { get; set; }

    public string? AlmoxNome { get; set; }

    public string? EmprCnpj { get; set; }

    public string? AlmoxFone { get; set; }

    public long ItemId { get; set; }

    public string? ItemNome { get; set; }

    public decimal? QtdeEntrada { get; set; }

    public decimal? QtdeSaida { get; set; }

    public decimal? QtdeReservada { get; set; }

    public decimal? SaldoEstoque { get; set; }

    public string? AlmoxNmResp { get; set; }
}
