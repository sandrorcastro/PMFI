namespace MVC.Models
{
    public class Economia
    {
        public long ImovelId { get; set; }
        public long EconomiaId { get; set; }
        public Imovel Imovel { get; set; }
        public ICollection<Economia_Entidade> Economia_Pessoas { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }
        public ICollection<Endereco_Entidade> Endereco_Entidades { get; set; }
        //Navegação de Teste
        public ICollection<Endereco> Enderecos { get; set; }
        //

       
       
     
    }
}
