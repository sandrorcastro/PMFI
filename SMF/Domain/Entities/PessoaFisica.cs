using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PessoaFisica :Pessoa
    {
        public string? PrimeiroNome { get; set; }
        public string? NomeMeio { get; set; }
        public string? Sobrenome { get; set; }
        public string? EstadoCivil { get; set; }
        public int? PaisId { get; set; }
        public Pais? Pais { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataObito { get; set; }
        [NotMapped]
        /*public int Idade
        {
            get => (int)Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.2425);
        }*/
        public string? Sexo { get; set; }
        public string? DefinicaoSexual { get; set; }
        [NotMapped]
        public string? NomeCompleto
        {
            get
            {
                return $"{PrimeiroNome} {NomeMeio} {Sobrenome}";
            }
        }
    }
}

