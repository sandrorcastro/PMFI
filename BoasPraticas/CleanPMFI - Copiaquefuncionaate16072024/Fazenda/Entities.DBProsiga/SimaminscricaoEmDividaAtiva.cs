﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SimaminscricaoEmDividaAtiva
{
    public long Idcontrole { get; set; }

    public string Cnpjfilial { get; set; } = null!;

    /// <summary>
    /// Código de identificação da dívida.
    /// </summary>
    public long? ImoIddivida { get; set; }

    public long? ConIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public short? CodTributo { get; set; }

    public short? AnoDivida { get; set; }

    public short? AnoInscricaoDividaAtiva { get; set; }

    public byte? TipoDocumento { get; set; }

    public string? Cnpjcpfcontribuinte { get; set; }

    public string? NomeContribuinte { get; set; }

    public decimal? ValorLancado { get; set; }

    public int? ImoDivTipoDivida { get; set; }

    public long? DivTipoBaixa { get; set; }

    public DateTime? DataBaixa { get; set; }

    public DateTime? DataInscricaoDa { get; set; }

    public int? NrEdital { get; set; }

    public long? IdTributo { get; set; }

    public decimal? Juros { get; set; }

    public string? InscricaoImob { get; set; }

    public long? Bimestre { get; set; }

    public long? Ano { get; set; }

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
}
