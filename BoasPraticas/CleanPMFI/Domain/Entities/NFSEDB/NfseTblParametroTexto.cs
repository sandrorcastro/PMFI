using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblParametroTexto
    {
        public int Idparam { get; set; }
        public string Stnome { get; set; } = null!;
        public string Sttexto { get; set; } = null!;
        public int Idform { get; set; }
        public string? Stdescricao { get; set; }
    }
}
