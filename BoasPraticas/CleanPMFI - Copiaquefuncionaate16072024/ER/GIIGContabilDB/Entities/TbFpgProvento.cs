using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFpgProvento
{
    public int IdProvento { get; set; }

    public short? IdEmpresa { get; set; }

    public string? NrCnpjempresa { get; set; }

    public string? DsProvento { get; set; }

    public string? DsTipoProvento { get; set; }

    public string? DsContaDebito { get; set; }

    public string? DsContaCredito { get; set; }

    public string? DsTipoDespesa { get; set; }

    public string? DsClassificacaoDotacao { get; set; }

    public decimal? VlProvento { get; set; }

    public short? NrCompAno { get; set; }

    public short? NrCompMes { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? DsErro { get; set; }

    public string? DsAlerta { get; set; }

    public string? DsCentroCusto { get; set; }

    public int? IdDotacao { get; set; }

    public int? IdNatDespesa { get; set; }

    public int? IdRecurso { get; set; }

    public int? IdItemEmpenhar { get; set; }

    public int? IdEmpenho { get; set; }

    public int? IdDespesa { get; set; }

    public int? IdSubAcaoTarefa { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? CdProvento { get; set; }

    public virtual ICollection<TbFpgProventosDesconto> TbFpgProventosDescontos { get; set; } = new List<TbFpgProventosDesconto>();
}
