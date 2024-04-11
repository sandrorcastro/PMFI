using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ProdRurPropriedade
{
    public int Idpropriedade { get; set; }

    public string? ProRuCodAnterior { get; set; }

    public string? ProRuNumInscrIncra { get; set; }

    public string? ProRuNome { get; set; }

    public int LogradId { get; set; }

    public string? ProRuComplemento { get; set; }

    public int CidadeId { get; set; }

    public int BairroId { get; set; }

    public string? ProRuCep { get; set; }

    public decimal? ProRuUtmzona { get; set; }

    public decimal? ProRuUtminicial { get; set; }

    public decimal? ProRuUtmfinal { get; set; }

    public decimal? ProRuCoordGeoLat { get; set; }

    public decimal? ProRuCoordGeoLong { get; set; }

    public string? ProRuNumRegistro { get; set; }

    public string? ProRuCartorio { get; set; }

    public decimal? ProRuAreaTotal { get; set; }

    public virtual ICollection<AguaRuraisHidrometro> AguaRuraisHidrometros { get; set; } = new List<AguaRuraisHidrometro>();

    public virtual Bairro Bairro { get; set; } = null!;

    public virtual Cidade Cidade { get; set; } = null!;

    public virtual Logradouro Lograd { get; set; } = null!;

    public virtual ICollection<ProdRurProprRurViasAcesso> ProdRurProprRurViasAcessos { get; set; } = new List<ProdRurProprRurViasAcesso>();

    public virtual ICollection<ProdRurPropriedadesRurProdutor> ProdRurPropriedadesRurProdutors { get; set; } = new List<ProdRurPropriedadesRurProdutor>();

    public virtual ICollection<ProdRurRecurPropriedade> ProdRurRecurPropriedades { get; set; } = new List<ProdRurRecurPropriedade>();
}
