using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblRegra
    {
        public NfseTblRegra()
        {
            NfseTblRegrasErros = new HashSet<NfseTblRegrasErro>();
        }

        public int Idregra { get; set; }
        public string? Stdescricao { get; set; }
        public string? Sttpchecagem { get; set; }
        public int Nusequencia { get; set; }
        public string Stformula { get; set; } = null!;
        public string Stvlretorno { get; set; } = null!;

        public virtual ICollection<NfseTblRegrasErro> NfseTblRegrasErros { get; set; }
    }
}
