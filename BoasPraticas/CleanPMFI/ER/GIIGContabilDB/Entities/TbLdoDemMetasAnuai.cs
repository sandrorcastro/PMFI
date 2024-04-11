using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoDemMetasAnuai
{
    public int IdDemMetasAnuais { get; set; }

    public int? IdVersao { get; set; }

    public short? NrAnoLdo { get; set; }

    public short? NrAnoReferencia { get; set; }

    public decimal? VlReTotalCorrente { get; set; }

    public decimal? VlRecTotalConstante { get; set; }

    public decimal? VlRecTotalPercPib { get; set; }

    public decimal? VlRecPrimCorrente { get; set; }

    public decimal? VlRecPrimConstante { get; set; }

    public decimal? VlRecPrimPercPib { get; set; }

    public decimal? VlDespTotalCorrente { get; set; }

    public decimal? VlDespTotalConstante { get; set; }

    public decimal? VlDespTotalPercPib { get; set; }

    public decimal? VlDespPrimCorrente { get; set; }

    public decimal? VlDespPrimConstante { get; set; }

    public decimal? VlDespPrimPercPib { get; set; }

    public decimal? VlResNomCorrente { get; set; }

    public decimal? VlResNomConstante { get; set; }

    public decimal? VlResNomPercPib { get; set; }

    public decimal? VlDivPublicaCorrente { get; set; }

    public decimal? VlDivPublicaConstante { get; set; }

    public decimal? VlDivPublicaPercPib { get; set; }

    public decimal? VlDivConsLiqCorrente { get; set; }

    public decimal? VlDivConsLiqConstante { get; set; }

    public decimal? VlDivConsLiqPercPib { get; set; }

    public decimal? VlRecPrimPppcorrente { get; set; }

    public decimal? VlRecPrimPppconstante { get; set; }

    public decimal? VlRecPrimPpppercPib { get; set; }

    public decimal? VlDespPrimPppcorrente { get; set; }

    public decimal? VlDespPrimPppconstante { get; set; }

    public decimal? VlDespPrimPpppercPib { get; set; }

    public short? Idempresa { get; set; }

    public short? NrAno { get; set; }
}
