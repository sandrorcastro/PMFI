using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEmpresasTipo
{
    public int EmprTipoId { get; set; }

    public string? EmprTipoDescricao { get; set; }

    public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; } = new List<SerIturEmpresasSemCmc>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
