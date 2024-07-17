using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoProjetosAndamento
{
    public int IdProjeto { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAnoLdo { get; set; }

    public short? NrAno { get; set; }

    public int? IdAcao { get; set; }

    public int? IdUnidadeMedida { get; set; }

    public decimal? VlPrevOrcQte { get; set; }

    public decimal? VlPrevOrcValor { get; set; }

    public decimal? NrExecOrcQte { get; set; }

    public decimal? VlExecOrcValor { get; set; }

    public decimal? NrSaldoExecQte { get; set; }

    public decimal? VlSaldoExecValor { get; set; }
}
