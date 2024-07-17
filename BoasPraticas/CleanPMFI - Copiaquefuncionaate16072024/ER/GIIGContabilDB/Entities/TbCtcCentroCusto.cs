using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtcCentroCusto
{
    public int IdCentroCusto { get; set; }

    public string? NmCentroCusto { get; set; }

    public string? DsCentroCusto { get; set; }

    public string? CdCentroCusto { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? IdContaContabil { get; set; }

    public short? NrNivel { get; set; }

    public int? IdCentroCustoSuperior { get; set; }

    public string? TpCentroCusto { get; set; }

    public string? FlCustoIndireto { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public string? CdContaContabil { get; set; }

    public virtual ICollection<TbCtcCentroCustosCriterio> TbCtcCentroCustosCriterios { get; set; } = new List<TbCtcCentroCustosCriterio>();

    public virtual ICollection<TbCtcCentroCustosIten> TbCtcCentroCustosItens { get; set; } = new List<TbCtcCentroCustosIten>();

    public virtual ICollection<TbCtcCentroCustosNaturezaDespesa> TbCtcCentroCustosNaturezaDespesas { get; set; } = new List<TbCtcCentroCustosNaturezaDespesa>();

    public virtual ICollection<TbCtcCentroCustosOrgaoUnidade> TbCtcCentroCustosOrgaoUnidades { get; set; } = new List<TbCtcCentroCustosOrgaoUnidade>();
}
