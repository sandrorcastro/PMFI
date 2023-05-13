namespace Domain.Entities
{
    public class Contato_Pessoa
    {
        public int ContatoId { get; set; }
        public long PessoaId { get; set; }
        public Contato? Contato { get; set; }
        public Pessoa? Pessoa { get; set;}
        public DateTime DataCadastro { get; set; }
        public bool? Ativo { get; set; }

    }
}