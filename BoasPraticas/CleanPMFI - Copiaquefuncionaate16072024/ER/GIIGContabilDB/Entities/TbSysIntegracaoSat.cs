using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSysIntegracaoSat
{
    public int IdIntegracao { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdConsignacao { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? FlTipo { get; set; }

    public short? NrAno { get; set; }

    public DateTime? DtGeracao { get; set; }

    public string? DsLogin { get; set; }

    public string? DsOrgao { get; set; }

    public string? NrCnpjtomador { get; set; }

    public int? NrInscricaoPrestador { get; set; }

    public string? NrCpfprestador { get; set; }

    public string? NrCnpjprestador { get; set; }

    public string? NrReferencia { get; set; }

    public DateTime? DtRetencao { get; set; }

    public decimal? VlIssqn { get; set; }

    public decimal? VlServico { get; set; }

    public decimal? NrAliquota { get; set; }

    public string? NmPrestador { get; set; }
}
