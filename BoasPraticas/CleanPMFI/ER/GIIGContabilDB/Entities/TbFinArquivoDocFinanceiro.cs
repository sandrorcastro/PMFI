using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinArquivoDocFinanceiro
{
    public int IdArquivo { get; set; }

    public int IdArquivoGerado { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdCcempresa { get; set; }

    public int? IdCcarrecadadora { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int NrSequencia { get; set; }

    public string? DsTipoArquivo { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsJustificativaExclusao { get; set; }

    public DateTime? DtExclusao { get; set; }

    public string? DsLoginExclusao { get; set; }

    public string? DsSigla { get; set; }
}
