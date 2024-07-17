using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbPlaAcoesMovimentosPm
{
    public int IdMovimento { get; set; }

    public int? IdAcao { get; set; }

    public short? NrMovimento { get; set; }

    public DateTime? DtMovimento { get; set; }

    public short? IdTipoMovimento { get; set; }

    public short? IdEmpresaExecutor { get; set; }

    public string? CdOrgaoResponsavel { get; set; }

    public string? CdUnidadeResponsavel { get; set; }

    public string? CdFuncao { get; set; }

    public string? CdSubFuncao { get; set; }

    public short? IdNaturezaAcao { get; set; }

    public short? IdTipoExecucaoAcao { get; set; }

    public short? IdTipoAcao { get; set; }

    public string? FlAcaoContinua { get; set; }

    public string? DsAcao { get; set; }

    public short? IdProduto { get; set; }

    public short? IdUnidadeMedida { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdVersaoMovimento { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public string? DsSigla { get; set; }

    public int? IdObjetivo { get; set; }
}
