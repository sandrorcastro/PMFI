namespace Domain.Entities
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
        public int? TipoResponsabilidadeId { get; set; }
        public TipoResponsabilidade? TipoResponsabilidade { get; set; }
        public bool? Proprietario { get; set; }
        public bool? Responsavel { get; set; }
        public bool? CoResponsavel { get; set; }
        public bool? Locatario { get; set; }
        public bool? Correspondente { get; set; }
    }
}