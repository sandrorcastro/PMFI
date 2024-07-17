using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Modulo
    {
        public Modulo()
        {
            Frms = new HashSet<Formulario>();
            Usus = new HashSet<Usuario>();
        }

        public int ModId { get; set; }
        public string? ModNome { get; set; }
        public string? ModDescricao { get; set; }

        public virtual ICollection<Formulario> Frms { get; set; }
        public virtual ICollection<Usuario> Usus { get; set; }
    }
}
