using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinArquivoRetorno
{
    public int IdIntegracao { get; set; }

    public int? IdEmpresa { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public short? NrAno { get; set; }

    public int? NrArquivoOrigem { get; set; }

    public int? NrArquivoRetorno { get; set; }

    public string? CdRetorno { get; set; }

    public string? NmArquivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
