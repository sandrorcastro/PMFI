using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class PsitipoPerfil
    {
        public PsitipoPerfil()
        {
            Formularios = new HashSet<Psiformulario>();
            Usuarios = new HashSet<Psiusuario>();
        }

        public long TipoPerfilId { get; set; }
        public string? TipPerfNome { get; set; }

        public virtual ICollection<Psiformulario> Formularios { get; set; }
        public virtual ICollection<Psiusuario> Usuarios { get; set; }
    }
}
