
using System.ComponentModel.DataAnnotations;
namespace VistoriaInLoco.Models
{
    public class Vistoria
    {

        [Key]
        public int IdVistoria { get; set; }
        public DateTime DataVistoria { get; set; }
        public string MatriculaFiscal { get; set; }

        public string InscricaoImobiliaria { get; set; }

        public string ResponsávelMatricula { get; set; }
        public string email { get; set; }
        public string whatsapp { get; set; }
        public string Caracteristica { get; set; }
        public int AreaTotalBCI { get; set; }
        public string? Alvara { get; set; }

        public string? NotificacaoAlvara { get; set; }

        public string? ProcessoAlvara { get; set; }

        public string? CVCOHabitese { get; set; }
        public string? NotificacaoCVCOHabitese { get; set; }

        public string? ProcessoCVCOHabitese { get; set; }

        public string? AnoTermino { get; set; }
        public int? QuantidadeQuartos {get;set;}
        public int? AreaAberta { get; set; }
        public int? AreaConstruidaFechada { get; set; }



    }
}
