using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcConsolidacaoOrcamento
{
    public int IdConsolidacao { get; set; }

    public short IdEmpresa { get; set; }

    public short NrAnoOrcamento { get; set; }

    public int? IdAto { get; set; }

    public int? NrLei { get; set; }

    public short? NrAnoLei { get; set; }

    public short? IdExecutor { get; set; }

    public short? IdOperacaoLoa { get; set; }

    public string TpAdministracao { get; set; } = null!;

    public decimal VlInicialReceitas { get; set; }

    public decimal VlInicialDespesas { get; set; }

    public decimal VlAtualizadoReceitas { get; set; }

    public decimal VlAtualizadoDespesas { get; set; }

    public decimal? VlIngressos { get; set; }

    public decimal? VlEgressos { get; set; }
}
