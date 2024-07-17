using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbTmpTribTerreno2018
{
    public long TerrenoId { get; set; }

    public int? QuadraId { get; set; }

    public string? TerrLote { get; set; }

    public int? JuriId { get; set; }

    public int? PedoId { get; set; }

    public int? LocQid { get; set; }

    public int? TopoId { get; set; }

    public int? FundoId { get; set; }

    public int? CalcaId { get; set; }

    public int? PatrId { get; set; }

    public int? VegeId { get; set; }

    public int? LimTid { get; set; }

    public int? InciId { get; set; }

    public decimal? TerrAreaTerreno { get; set; }

    public string? TerrReferenciaAnterior { get; set; }

    public int TerrPontosTerreno { get; set; }

    public string? QuadraLoteamento { get; set; }

    public string? LoteLoteamento { get; set; }

    public string? TipoCondominio { get; set; }

    public string? LoteCondominio { get; set; }

    public int? Loteamento { get; set; }

    public long? NumeroCadastroCanadas { get; set; }

    public decimal? AreaAbertaCoberta { get; set; }

    public decimal? ValorVenalTerreno { get; set; }

    public string? TerrObs { get; set; }

    public decimal? AreaUsoComum { get; set; }
}
