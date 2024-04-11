using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasTipoEntidade
{
    public short EmprTipoEntidadeId { get; set; }

    public string? EmprTipoEntidadeDescricao { get; set; }

    public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; } = new List<SerIturEmpresasSemCmc>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
