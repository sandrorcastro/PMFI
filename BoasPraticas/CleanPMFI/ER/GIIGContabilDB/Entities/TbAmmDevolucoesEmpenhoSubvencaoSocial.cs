using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmDevolucoesEmpenhoSubvencaoSocial
{
    public int IdDevolucaoEmpenho { get; set; }

    public short? IdEmpresa { get; set; }

    public int? CdSubvencaoSocial { get; set; }

    public short? NrAno { get; set; }

    public string? CdPrestacao { get; set; }

    public int? NrEmpenho { get; set; }

    public short? NrAnoEmpenho { get; set; }
}
