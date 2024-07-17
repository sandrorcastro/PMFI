using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Regio
{
    public int Idregiao { get; set; }

    public string? Descricao { get; set; }

    public int? CidadeId { get; set; }

    public decimal? PercentualUvc { get; set; }

    /// <summary>
    /// Valor da Longitude na area central da região
    /// </summary>
    public string? CentroGrauLon { get; set; }

    /// <summary>
    /// Valor da Latitude na area central da região
    /// </summary>
    public string? CentroGrauLat { get; set; }

    public virtual Cidade? Cidade { get; set; }

    public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; } = new List<HabAtendimento>();

    public virtual ICollection<HabOpcaoMoradium> HabOpcaoMoradia { get; set; } = new List<HabOpcaoMoradium>();

    public virtual ICollection<Loteamento> Loteamentos { get; set; } = new List<Loteamento>();
}
