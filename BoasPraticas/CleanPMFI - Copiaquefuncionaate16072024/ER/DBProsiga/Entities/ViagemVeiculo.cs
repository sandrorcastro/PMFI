using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ViagemVeiculo
{
    public long ViagemVeiculoId { get; set; }

    public long VeiculoId { get; set; }

    public long ServId { get; set; }

    public DateTime DataSaida { get; set; }

    public DateTime? DataChegada { get; set; }

    public DateTime HoraSaida { get; set; }

    public DateTime? HoraChegada { get; set; }

    public string? Destino { get; set; }

    public long MotViagemId { get; set; }

    public long? KmVeiculo { get; set; }

    public long? KmPretendida { get; set; }

    public bool ComMotorista { get; set; }
}
