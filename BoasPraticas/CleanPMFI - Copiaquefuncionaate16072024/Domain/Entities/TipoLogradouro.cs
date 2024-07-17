using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TipoLogradouro
    {
        public int IdTipoLogadouro { get; set; }
        public string? Dstipologradouro { get; set; }
        public virtual ICollection<Logradouro>? Logradouros { get; set; }
    }
}
