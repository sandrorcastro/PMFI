using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTipoPlantasValore
{
    public int Idplanta { get; set; }

    public string? NomePlanta { get; set; }

    public decimal? ValorM2 { get; set; }

    public int? AnoPlanta { get; set; }

    public int? CategId { get; set; }

    public int? IdplantaOrigem { get; set; }

    public virtual TribCategoriaEdificacao? Categ { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();

    public virtual ICollection<TribParamCalculo> TribParamCalculos { get; set; } = new List<TribParamCalculo>();
}
