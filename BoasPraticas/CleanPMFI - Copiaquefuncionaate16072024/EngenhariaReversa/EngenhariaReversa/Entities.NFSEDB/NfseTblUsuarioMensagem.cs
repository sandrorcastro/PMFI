using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblUsuarioMensagem
    {
        public int Idmensagem { get; set; }
        public string Idusuario { get; set; } = null!;
        public string? Stsituacao { get; set; }
    }
}
