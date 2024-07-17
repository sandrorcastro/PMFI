using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Bairro
{
    public int BairroId { get; set; }

    public string? BaiNome { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? Host { get; set; }

    public long? Idregiao { get; set; }

    public virtual ICollection<Contribuinte> Contribuintes { get; set; } = new List<Contribuinte>();

    public virtual ICollection<ProdRurPropriedade> ProdRurPropriedades { get; set; } = new List<ProdRurPropriedade>();

    public virtual ICollection<SerIturAtrativosTuristico> SerIturAtrativosTuristicos { get; set; } = new List<SerIturAtrativosTuristico>();

    public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; } = new List<SerIturEmpresasSemCmc>();

    public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; } = new List<TribAlvaraTermoDispenca>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
