namespace Domain.Entities
{
    public class Endereco_Entidade
    {
        //public long Endereco_EntidadeId { get; set; }
        public long EntidadeId { get; set; }
        //public long EntidadeId { get; set; }
        public long EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public string? Numero { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public string? CEP { get; set; }
        public int? TipoEntidadeId { get; set; }
        public bool? Correspondencia { get; set; }
        public bool? Principal { get; set; }
        public bool? Ativo { get; set; }
        public long? EconomiaId { get; set; }
        public Economia? Economia { get; set; }
        public Imovel? Imovel { get; set;}
       

    }
}
