namespace MVC.Models
{
    public class Pessoa
    {
        public long PessoaId { get; set; }
        public ICollection<Endereco_Entidade>? Enderecos { get; set; }
        //public ICollection<Endereco>? Enderecos { get; set; }
        public ICollection<Economia_Entidade>? Economias { get; set; }
        //blic ICollection<Economia>? Economias { get; set; }

    }
}


