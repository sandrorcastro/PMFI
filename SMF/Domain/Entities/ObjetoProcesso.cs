namespace Domain.Entities
{
    public class ObjetoProcesso
    {
  


     
       // public long ObjetoProcessoId { get; set; }
        public long ProcessoId { get; set; }
        public Processo Processo { get; set; }
        //public ICollection<Processo>? Processos { get; set; }
        public int TipoObjetoProcesso { get; set; }
        public string DescricaoObjetoProcesso { get; set; }
        public long? PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
        public long? EconomiaId { get; set; }   
        public Economia? Economia { get; set; }
        public long? ImovelId { get; set; }
        public Imovel? Imovel { get; set; }
        public long? EnderecoId { get;set; }
        public Endereco? Endereco { get; set; }
    }
}