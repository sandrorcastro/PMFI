namespace MVC.Models
{
    public class Economia
    {
        public long ImovelId { get; set; }
        public long EconomiaId { get; set; }
        public Imovel Imovel { get; set; }
        public ICollection<Economia_Entidade> Pessoas { get; set; }
        //public ICollection<Pessoa> Pessoas { get; set; }
        public ICollection<Endereco_Entidade> Enderecos { get; set; }
        //Navegação de Teste
        //public ICollection<Endereco> Enderecos { get; set; }
        //

       
       
     
    }
}
