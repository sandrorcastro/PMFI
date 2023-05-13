namespace Domain.Entities
{
    public class Pessoa
    {
        public long PessoaId { get; set; }
        public string Nome { get; set; }
        public int TipoPessoaId { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool? Ativo { get; set; }
        public long? conId { get; set; }
        public ICollection<Endereco_Entidade>? Enderecos { get; set; }
        public ICollection<DocumentoPessoa>? Documentos { get; set; }
        //public ICollection<Economia_Pessoa>? Economias { get; set; }
        public ICollection<Economia_Entidade>? Economias { get; set; }
        public ICollection<Contato_Pessoa>? Contatos { get; set; }

    }
}


