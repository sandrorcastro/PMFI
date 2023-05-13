
namespace Domain.Entities
{
    public class Endereco
    {
        public long EnderecoId { get; set; }
        public int? CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
        public long? LogradouroId { get; set; }
        public Logradouro? Logradouro { get; set; }
        public long? BairroId { get; set; }
        public Bairro? Bairro { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
        public ICollection<Endereco_Entidade>? Entidades { get; set; }
        public bool? Ativo { get; set; }    
    }
}
