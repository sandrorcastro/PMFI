using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Psimodulo
    {
        public Psimodulo()
        {
            Psiformularios = new HashSet<Psiformulario>();
        }

        public long ModuloId { get; set; }
        public string? ModNome { get; set; }
        public long AplicativoId { get; set; }
        public string? ModSigla { get; set; }

        public virtual Psiaplicativo Aplicativo { get; set; } = null!;
        public virtual ICollection<Psiformulario> Psiformularios { get; set; }
    }
}
