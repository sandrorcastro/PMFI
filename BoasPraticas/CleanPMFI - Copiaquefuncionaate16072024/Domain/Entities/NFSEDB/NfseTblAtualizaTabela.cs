using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblAtualizaTabela
    {
        public int Idatualizacao { get; set; }
        public DateTime Dtregistro { get; set; }
        public DateTime? Dtexecucao { get; set; }
        public string Storigem { get; set; } = null!;
        public string Stoperacao { get; set; } = null!;
        public string Idregistro { get; set; } = null!;
        public string Stsituacao { get; set; } = null!;
        public string? Idregistrofk { get; set; }
    }
}
