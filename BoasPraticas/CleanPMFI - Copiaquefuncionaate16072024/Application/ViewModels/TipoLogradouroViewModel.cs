using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public partial class TipoLogradouroViewModel
    {
        public int IdTipoLogadouro { get; set; }
        public string? Dstipologradouro { get; set; }
        public virtual ICollection<Logradouro>? Logradouros { get; set; }
    }
}
