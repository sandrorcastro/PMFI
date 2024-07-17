using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbTrbRolDivida
{
    public int IdDivida { get; set; }

    public short? NrExercicio { get; set; }

    public byte? NrBimestre { get; set; }

    public byte? TpDivida { get; set; }

    public string? TpOperacao { get; set; }

    public short? CdTributo { get; set; }

    public string? CdDivida { get; set; }

    public short? NrParcela { get; set; }

    public long? IdDividaOrigem { get; set; }

    public byte? TpCadastro { get; set; }

    public short? NrAnoDivida { get; set; }

    public short? NrAnoGeracao { get; set; }

    public bool? TpDocumento { get; set; }

    public string? NrDocumento { get; set; }

    public string? NmContribuinte { get; set; }

    public int? NrEdital { get; set; }

    public DateTime? DtEdital { get; set; }

    public byte? CdTipoDeducao { get; set; }

    public string? DsDescricaoDeducao { get; set; }

    public decimal VlOperacao { get; set; }

    public DateTime? DtOperacao { get; set; }

    public bool? FlClassificado { get; set; }

    public string? DsTributo { get; set; }

    public bool? FlPagamentoTotal { get; set; }
}
