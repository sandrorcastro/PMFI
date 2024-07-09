using Application.Interfaces.DBProsiga;
using Application.Services.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Specs.DBProsiga;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.FluentUI.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;


namespace BlazorWebAppITBI.Models
{
    public class Anexo
    {
        
        public TribItbidocumentoTipo Doc { get; set; }
        public TribItbidocumentoTipo? Tipo { get; set; }
        public bool carregado { get; set; }

        public string? nomearquivo { get; set; }
        public string? nomeDEFINITIVO { get; set; }
        public string pertenceA {  get; set; }
        public InputFile InputFile { get; set; }
        //[Required(ErrorMessage = "Percentual Adquirido é obrigatório")]
        public List<IBrowserFile> AnexoBf = new List<IBrowserFile>();
        public IBrowserFile browserFile { get; set; }
        //public IBrowserFile Anexo = new IBrowserFile();
        public FluentInputFile? fluentInputFile { get; set; }


    }
}
