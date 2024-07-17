using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasAtivAtributo
{
    public int AtividadeAtributoId { get; set; }

    public long EmprCmc { get; set; }

    public string Atividade { get; set; } = null!;

    public int IdAtributo { get; set; }

    public string DsValor { get; set; } = null!;

    public virtual TbEmpAtributosDinamico IdAtributoNavigation { get; set; } = null!;

    public virtual TribEmpresasAtiv TribEmpresasAtiv { get; set; } = null!;
}
