using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Psiusuario
    {
        public Psiusuario()
        {
            TipoPerfils = new HashSet<PsitipoPerfil>();
        }

        public long UsuarioId { get; set; }
        public string? UsuarioEmail { get; set; }
        public DateTime? UsuarioDtCad { get; set; }
        public long? UsuarioInclusao { get; set; }
        public long? ConId { get; set; }

        public virtual Contribuinte? Con { get; set; }

        public virtual ICollection<PsitipoPerfil> TipoPerfils { get; set; }
    }
}
