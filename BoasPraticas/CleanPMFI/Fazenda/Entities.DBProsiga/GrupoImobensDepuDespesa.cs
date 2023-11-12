using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GrupoImobensDepuDespesa
{
    public long IdGrupoDespesa { get; set; }

    public string? DePuTipoDespesa { get; set; }

    public string? ImoInscricao { get; set; }

    public int? DePuAno { get; set; }

    public int? DePuNumero { get; set; }

    public decimal? DepuValor { get; set; }

    public string? CnpjFilial { get; set; }

    public virtual ImobensImovei? ImobensImovei { get; set; }
}
