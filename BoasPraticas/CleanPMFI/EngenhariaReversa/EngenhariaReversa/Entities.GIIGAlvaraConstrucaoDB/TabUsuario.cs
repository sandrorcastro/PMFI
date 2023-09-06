using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabUsuario
    {
        public int UsuaId { get; set; }
        public int PessId { get; set; }
        public string UsuaSenha { get; set; } = null!;
        public string UsuSituacao { get; set; } = null!;

        public virtual TabPessoa Pess { get; set; } = null!;
    }
}
