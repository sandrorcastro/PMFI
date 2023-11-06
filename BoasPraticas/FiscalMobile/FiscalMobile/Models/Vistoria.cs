
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FiscalMobile.Models
{
    public class Vistoria  //: INotifyPropertyChanged
    {

        /*  public Vistoria()
          {

          }*/
        [Key]
        public int IdVistoria { get; set; }
        public string DataVistoria { get; set; }
        public string MatriculaFiscal { get; set; }

        public string InscricaoImobiliaria { get; set; }

        public string? ResponsavelBCI { get; set; }
        public string ResponsavelMatricula { get; set; }
        public string Email { get; set; }
        public string Whatsapp { get; set; }
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

       // public event PropertyChangedEventHandler PropertyChanged;
    }
}
