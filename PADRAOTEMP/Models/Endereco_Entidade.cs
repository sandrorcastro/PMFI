namespace MVC.Models
{
    public class Endereco_Entidade
    {
        //public long Endereco_EntidadeId { get; set; }
        public long EntidadeId { get; set; }
        //public long EntidadeId { get; set; }
        public long EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
       
        
        public string? Numero { get; set; }
        public int? TipoEntidadeId { get; set; }
    
       
        //Navegação de Teste
        public Imovel? Imovel { get; set;}
        public Economia? Economia { get; set; }
        public Pessoa? Pessoa { get; set; }
        ///


    }
}
