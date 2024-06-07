using Domain.Entities.DBProsiga;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppITBI.Models
{
    public class Transmitente
    {
        public Contribuinte Contribuinte { get; set; }
        [Required(ErrorMessage = "Percentual Transmitido é obrigatório")]
        public string? percentualtransmitido { get; set; } = "100";
     
        /*public string? _percentualtransmitido { get; set; } = "100";

        public string? percentualtransmitido
        {
            get => _percentualtransmitido;
            set
            {
                if (int.TryParse(value, out int parsedValue))
                {
                    if (parsedValue >= 0 && parsedValue <= 100)
                    {
                        _percentualtransmitido = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(nameof(percentualtransmitido), "O valor deve estar entre 0 e 100.");
                    }
                }
                else
                {
                    throw new ArgumentException("O valor deve ser um número válido.");
                }
            }
        }

        public Transmitente()
        {
            _percentualtransmitido = "100"; // Valor padrão
        }
        */
    }
}
