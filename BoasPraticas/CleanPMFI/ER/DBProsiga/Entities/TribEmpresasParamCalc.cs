using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasParamCalc
{
    public int ParamCalcId { get; set; }

    public string? ParamCalcNome { get; set; }

    public string? ParamCalcDescricao { get; set; }

    public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; } = new List<TribAtivTributosEmpresa>();

    public virtual ICollection<TribEmpresasTributo> TribEmpresasTributos { get; set; } = new List<TribEmpresasTributo>();
}
