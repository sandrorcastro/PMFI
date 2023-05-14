using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ViewModels
{
    //[Bind("FluxoProcessoId,Descricao,TipoProcessoId,")]
    public class FluxoProcessoViewModel
    {
        
        public int FluxoProcessoId { get; set; }
        public string Descricao { get; set; }
        public int TipoProcessoId { get; set; }
      //  [BindProperty]
        public TipoProcesso? TipoProcesso { get; set; }
        public int TipoEtapaId { get; set; }
        public TipoEtapa? TipoEtapa { get; set; }

    }
}
