namespace Domain.Entities
{
    public class Bairro
    {
        public long BairroId { get; set; }   
        public string? Descricao { get; set; }
        public long? RegiaoId { get; set; }   
        public Regiao? Regiao { get; set; }
        public int? CidadeId { get; set; }
        public Cidade?  Cidade { get; set; }
      //  public ICollection<Cidade_Bairro>? Cidades { get; set; }
    }
}
