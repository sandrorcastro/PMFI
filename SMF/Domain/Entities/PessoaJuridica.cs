namespace Domain.Entities
{
    public class PessoaJuridica :Pessoa
    {
        public string? RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? InscricaoEstadual { get; set; }  
    }
}

