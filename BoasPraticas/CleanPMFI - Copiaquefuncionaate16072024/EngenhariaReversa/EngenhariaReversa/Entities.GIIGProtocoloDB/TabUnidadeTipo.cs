using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabUnidadeTipo
    {
        public TabUnidadeTipo()
        {
            TabUnidades = new HashSet<TabUnidade>();
        }

        public byte TipoUnidId { get; set; }
        public string? TipoUnidNome { get; set; }
        public byte TipoUnidNivel { get; set; }

        public virtual ICollection<TabUnidade> TabUnidades { get; set; }
    }
}
