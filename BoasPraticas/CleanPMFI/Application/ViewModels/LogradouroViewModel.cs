using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public partial class LogradouroViewModel
    {
        public int IdLogradouro { get; set; }
        public int IdTipoLogradouro { get; set; }
        public virtual TipoLogradouro? TipoLogradouro { get; set; }    
        public string? LogradTipo { get; set; }
        public string? NomeLogradouro { get; set; }
        
    }
}
