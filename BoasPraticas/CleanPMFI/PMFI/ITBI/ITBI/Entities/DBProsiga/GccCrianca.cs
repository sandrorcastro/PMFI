using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccCrianca
{
    public string CriCnpjmembro { get; set; } = null!;

    public long CriId { get; set; }

    public string? CriNome { get; set; }

    public DateTime? CriDtNasc { get; set; }

    public string? CriSexo { get; set; }

    public string? CriRua { get; set; }

    public string? CriBairro { get; set; }

    public string? CriComplemento { get; set; }

    public string? CriCidade { get; set; }

    public string? CriUf { get; set; }

    public string? CriTelResiden { get; set; }

    public virtual ICollection<GccCompFamiliar> GccCompFamiliars { get; set; } = new List<GccCompFamiliar>();

    public virtual ICollection<GccCriCreche> GccCriCreches { get; set; } = new List<GccCriCreche>();

    public virtual ICollection<GccMovtoQuest> GccMovtoQuests { get; set; } = new List<GccMovtoQuest>();
}
