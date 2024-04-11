using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecReceitasBaixaOrcamentarium
{
    public int IdReceitaEmpenho { get; set; }

    public short? NrAno { get; set; }

    public short? IdEmpresa { get; set; }

    public string? DsTipoEmpresa { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdCcfavorecido { get; set; }

    public string? CdNatDespesa { get; set; }

    public string? CdReceita { get; set; }

    public string? CdContaContabilDisponivel { get; set; }

    public int? IdRecurso { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }
}
