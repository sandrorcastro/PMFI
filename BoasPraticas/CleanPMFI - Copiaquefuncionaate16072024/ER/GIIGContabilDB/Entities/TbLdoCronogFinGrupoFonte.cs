using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoCronogFinGrupoFonte
{
    public int IdCronogFinGrupFonte { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? NrBimestreLrf { get; set; }

    public int? IdGrupoFontes { get; set; }

    public decimal? VlRecCorrentes { get; set; }

    public decimal? VlRecCapital { get; set; }

    public decimal? VlDespCorrentes { get; set; }

    public decimal? VlDespCapital { get; set; }

    public decimal? VlRecCorrentesIntra { get; set; }

    public decimal? VlRecCapitalIntra { get; set; }

    public decimal? VlDespCorrentesIntra { get; set; }

    public decimal? VlDespCapitalIntra { get; set; }

    public decimal? VlDespRap { get; set; }

    public decimal? VlDespConsignacoes { get; set; }

    public decimal? VlRecDisponibilidade { get; set; }

    public decimal? VlRecIngressos { get; set; }

    public decimal? VlDespEgressos { get; set; }
}
