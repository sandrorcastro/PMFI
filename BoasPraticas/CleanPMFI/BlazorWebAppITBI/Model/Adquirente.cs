using Domain.Entities.DBProsiga;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppITBI.Models
{
    public class Adquirente
    {
        public Contribuinte Contribuinte { get; set; }
      //  [Required(ErrorMessage = "Percentual Adquirido é obrigatório")]
        public string? percentualAdquirido { get; set; }
        public List<Anexo>? AnexosExigidos { get; set; }
        public string Titularidade { get; set; }
        public  bool isento { get; set; } = false;
        public bool novocontribuinte { get; set; } = false;
        public string sainoboleto { get; set; } ="Não";

    }
}
