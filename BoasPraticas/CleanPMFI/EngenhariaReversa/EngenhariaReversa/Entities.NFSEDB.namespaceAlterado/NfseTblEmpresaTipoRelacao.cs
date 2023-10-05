using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaTipoRelacao
    {
        public int Idtiporelacao { get; set; }
        public string Stdescricao { get; set; } = null!;
    }
}
