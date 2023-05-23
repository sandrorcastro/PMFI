namespace MVC.Models
{
    public class Economia_Entidade
    {
       // public long Economia_EntidadeId { get; set; }
        public long? ImovelId { get; set; }
        public Imovel? Imovel { get; set; }
        public long? EconomiaId { get; set; }
        public Economia? Economia { get; set; }
        public long? PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
      
    }
}