using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Cidade
{
    public int CidadeId { get; set; }

    public string? CidNome { get; set; }

    public string? CidUf { get; set; }

    /// <summary>
    /// Código Estadual do Fundo Municipal de Participação
    /// </summary>
    public string? CidFmp { get; set; }

    public int? PaisId { get; set; }

    public int? CdIbge { get; set; }

    public virtual ICollection<Contribuinte> Contribuintes { get; set; } = new List<Contribuinte>();

    public virtual Paise? Pais { get; set; }

    public virtual ICollection<ProdRurPropriedade> ProdRurPropriedades { get; set; } = new List<ProdRurPropriedade>();

    public virtual ICollection<Regio> Regios { get; set; } = new List<Regio>();

    public virtual ICollection<SaudePacienteXxxxxx> SaudePacienteXxxxxxes { get; set; } = new List<SaudePacienteXxxxxx>();

    public virtual ICollection<SerIturAtrativosTuristico> SerIturAtrativosTuristicos { get; set; } = new List<SerIturAtrativosTuristico>();

    public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; } = new List<SerIturEmpresasSemCmc>();

    public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; } = new List<TribAlvaraTermoDispenca>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
