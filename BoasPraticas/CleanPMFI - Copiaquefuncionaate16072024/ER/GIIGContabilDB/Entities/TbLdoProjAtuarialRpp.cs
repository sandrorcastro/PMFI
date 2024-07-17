using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoProjAtuarialRpp
{
    public int IdProjAtuarial { get; set; }

    public int? IdEmpresa { get; set; }

    public short? NrAnoLdo { get; set; }

    public short? NrAno { get; set; }

    public decimal? VlReceitasPrev { get; set; }

    public decimal? VlDespesasPrev { get; set; }

    public decimal? VlSaldoFinExercicio { get; set; }
}
