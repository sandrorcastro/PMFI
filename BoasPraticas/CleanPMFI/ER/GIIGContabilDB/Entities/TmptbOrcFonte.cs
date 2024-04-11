using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TmptbOrcFonte
{
    public int IdFonte { get; set; }

    public short IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string CdFonte { get; set; } = null!;

    public string? DsFonte { get; set; }

    public string? FlPadraoTce { get; set; }

    public string? DsTipoFonte { get; set; }

    public decimal? VlSaldoInicial { get; set; }

    public int? IdFonteSuperior { get; set; }

    public string? DsFonteRecurso { get; set; }

    public DateTime? DtCadastro { get; set; }
}
