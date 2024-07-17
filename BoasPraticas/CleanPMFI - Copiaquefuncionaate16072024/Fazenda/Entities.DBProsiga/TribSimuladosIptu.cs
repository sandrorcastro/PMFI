using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSimuladosIptu
{
    public int SimuId { get; set; }

    public string? SimuNome { get; set; }

    public DateTime? SimuData { get; set; }

    public short? SimuAno { get; set; }

    public decimal? SimuVlrUf { get; set; }

    public string? SimuImportado { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? SimuVencUnica1 { get; set; }

    public decimal? SimuDescUnica1 { get; set; }

    public DateTime? SimuVencUnica2 { get; set; }

    public decimal? SimuDescUnica2 { get; set; }

    public DateTime? SimuDataParc1 { get; set; }

    public string? SimuCalculado { get; set; }

    public short? SimuParcelas { get; set; }

    public virtual ICollection<TribSimuladoIptuoperaco> TribSimuladoIptuoperacos { get; set; } = new List<TribSimuladoIptuoperaco>();

    public virtual ICollection<TribSimuladosIptuimovei> TribSimuladosIptuimoveis { get; set; } = new List<TribSimuladosIptuimovei>();
}
