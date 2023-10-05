using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblGrupoAcessoUsuario
    {
        public int Idgrupoacess { get; set; }
        public string Idusuario { get; set; } = null!;
    }
}
