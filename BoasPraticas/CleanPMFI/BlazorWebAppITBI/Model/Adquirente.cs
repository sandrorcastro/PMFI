using Domain.Entities.DBProsiga;

namespace BlazorWebAppITBI.Models
{
    public class Adquirente
    {
        public Contribuinte Contribuinte { get; set; }
        public string? percentualAdquirido { get; set; }
    }
}
