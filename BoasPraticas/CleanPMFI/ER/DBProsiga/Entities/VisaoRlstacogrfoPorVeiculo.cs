using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VisaoRlstacogrfoPorVeiculo
{
    public long VistId { get; set; }

    public int ItemVistId { get; set; }

    public string? ItemVistNome { get; set; }

    public string? Vvobs { get; set; }

    public DateTime? VistData { get; set; }

    public DateTime? VistDataValidade { get; set; }

    public long FzveiId { get; set; }

    public string? Placa { get; set; }

    public string? Chassi { get; set; }

    public string? MarcaNome { get; set; }

    public string? ModNome { get; set; }

    public string? EspecieNome { get; set; }

    public int? AnoFabric { get; set; }

    public int? AnoModelo { get; set; }
}
