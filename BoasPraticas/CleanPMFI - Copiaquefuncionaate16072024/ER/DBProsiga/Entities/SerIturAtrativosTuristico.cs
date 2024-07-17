using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SerIturAtrativosTuristico
{
    public long AtrativoId { get; set; }

    public string? AtrativoLogradouro { get; set; }

    public string? AtrativoNumLograd { get; set; }

    public int? BairroId { get; set; }

    public int CidadeId { get; set; }

    public string? AtrativoNome { get; set; }

    public string? AtrativoDescricao { get; set; }

    public string? AtrativoObservacao { get; set; }

    public string? AtrativoHomePage { get; set; }

    public string? AtrativoEmail { get; set; }

    public string? AtrativoTelefone { get; set; }

    public virtual Bairro? Bairro { get; set; }

    public virtual Cidade Cidade { get; set; } = null!;

    public virtual ICollection<SerIturAtrativosServicosEquipamento> SerIturAtrativosServicosEquipamentos { get; set; } = new List<SerIturAtrativosServicosEquipamento>();

    public virtual ICollection<SerIturContribAtrativosTuristico> SerIturContribAtrativosTuristicos { get; set; } = new List<SerIturContribAtrativosTuristico>();

    public virtual ICollection<SerIturObjetoAtrativosTuristico> SerIturObjetoAtrativosTuristicos { get; set; } = new List<SerIturObjetoAtrativosTuristico>();

    public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; } = new List<SeriTurMovAtendimento>();

    public virtual ICollection<SerIturObjetoDadosEstatistico> DadoEstatisticos { get; set; } = new List<SerIturObjetoDadosEstatistico>();

    public virtual ICollection<SerIturDatasHistorica> DataHists { get; set; } = new List<SerIturDatasHistorica>();

    public virtual ICollection<SerIturDestino> Destinos { get; set; } = new List<SerIturDestino>();
}
