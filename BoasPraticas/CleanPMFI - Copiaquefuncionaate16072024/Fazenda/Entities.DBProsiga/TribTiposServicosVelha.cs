using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTiposServicosVelha
{
    public string ServId { get; set; } = null!;

    public string? ServDescricao { get; set; }

    public string? ServPeriodo { get; set; }

    public decimal? ServAliquota { get; set; }

    /// <summary>
    /// deve ser informado se este serviço deve ou não ser enquadrado como micro empresa
    /// </summary>
    public string? ServEnquadraMicroEmpresa { get; set; }
}
