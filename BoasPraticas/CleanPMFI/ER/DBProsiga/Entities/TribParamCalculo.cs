using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribParamCalculo
{
    public int TparamId { get; set; }

    public int ParamId { get; set; }

    public string? ParamNome { get; set; }

    public decimal? Fator { get; set; }

    public int? Pontos { get; set; }

    public string? CalculaImpostos { get; set; }

    public string? CaracId { get; set; }

    public virtual TribTipoParamCalculo Tparam { get; set; } = null!;

    public virtual ICollection<TribAlvaraConstrucaoParam> TribAlvaraConstrucaoParams { get; set; } = new List<TribAlvaraConstrucaoParam>();

    public virtual ICollection<TribDepreciacaoIdade> TribDepreciacaoIdades { get; set; } = new List<TribDepreciacaoIdade>();

    public virtual ICollection<TribEdifParamCalculo> TribEdifParamCalculos { get; set; } = new List<TribEdifParamCalculo>();

    public virtual ICollection<TribIsencaoIncidencium> TribIsencaoIncidencia { get; set; } = new List<TribIsencaoIncidencium>();

    public virtual ICollection<TribUtilizTributo> TribUtilizTributos { get; set; } = new List<TribUtilizTributo>();

    public virtual ICollection<TribTipoPlantasValore> Idplanta { get; set; } = new List<TribTipoPlantasValore>();
}
