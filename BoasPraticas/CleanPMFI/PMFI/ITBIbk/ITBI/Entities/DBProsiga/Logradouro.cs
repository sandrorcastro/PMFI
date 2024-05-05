using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Logradouro
{
    public int LogradId { get; set; }

    public string? LogradTipo { get; set; }

    public string? LogradNome { get; set; }

    public virtual ICollection<ProdRurPropriedade> ProdRurPropriedades { get; set; } = new List<ProdRurPropriedade>();

    public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; } = new List<SerIturEmpresasSemCmc>();

    public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; } = new List<TribAlvaraTermoDispenca>();

    public virtual ICollection<TribAmostraMercado> TribAmostraMercados { get; set; } = new List<TribAmostraMercado>();

    public virtual ICollection<TribCmprocessoLagrad> TribCmprocessoLagrads { get; set; } = new List<TribCmprocessoLagrad>();

    public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; } = new List<TribCmprocesso>();

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();

    public virtual ICollection<TribTestadasTerreno> TribTestadasTerrenos { get; set; } = new List<TribTestadasTerreno>();
}
