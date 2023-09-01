using PMFI.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PMFI.Application.ViewModels
{
    public class UfViewModel
    {
        public UfViewModel()
        {
            Cidades = new HashSet<CidadeViewModel>();
        }

        public int IdUf { get; set; }
        public string? Sigla { get; set; }
        public string Nome { get; set; } = null!;
        public int IdPais { get; set; }
        public int? CodigoIbge { get; set; }

        public virtual PaisViewModel IdPaisNavigation { get; set; } = null!;
        public virtual ICollection<CidadeViewModel> Cidades { get; set; }
    }
}
