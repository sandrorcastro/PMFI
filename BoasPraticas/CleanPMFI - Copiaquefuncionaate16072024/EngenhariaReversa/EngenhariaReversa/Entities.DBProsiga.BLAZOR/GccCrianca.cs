using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class GccCrianca
    {
        public GccCrianca()
        {
            GccCompFamiliars = new HashSet<GccCompFamiliar>();
            GccCriCreches = new HashSet<GccCriCreche>();
            GccMovtoQuests = new HashSet<GccMovtoQuest>();
        }

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

        public virtual ICollection<GccCompFamiliar> GccCompFamiliars { get; set; }
        public virtual ICollection<GccCriCreche> GccCriCreches { get; set; }
        public virtual ICollection<GccMovtoQuest> GccMovtoQuests { get; set; }
    }
}
