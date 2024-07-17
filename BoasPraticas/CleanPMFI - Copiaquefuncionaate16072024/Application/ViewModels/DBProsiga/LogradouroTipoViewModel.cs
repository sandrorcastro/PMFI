using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;

namespace Application.ViewModels.DBProsiga
{
    public partial class LogradouroTipoViewModel
    {
        public int IdTipoLogadouro { get; set; }
        public string? Dstipologradouro { get; set; }
        public virtual ICollection<Logradouro>? Logradouros { get; set; }
    }
}
