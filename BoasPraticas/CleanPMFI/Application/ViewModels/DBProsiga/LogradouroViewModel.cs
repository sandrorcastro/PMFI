using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;

namespace Application.ViewModels.DBProsiga
{
    public partial class LogradouroViewModel
    {
        public int IdLogradouro { get; set; }
        public int IdTipoLogradouro { get; set; }
        public virtual Logradourotipo? LogradouroTipo { get; set; }    
        public string? LogradTipo { get; set; }
        public string? NomeLogradouro { get; set; }
        
    }
}
