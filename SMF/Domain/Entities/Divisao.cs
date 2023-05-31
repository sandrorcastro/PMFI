namespace Domain.Entities
{
    public class Divisao
    {
        public int DivisaoId { get; set; }
        public int? UnidadeId { get; set; }
        public Unidade? Unidade { get; set; }

        public string? Descricao { get; set; }

        public string? Atribuicao { get; set; }

        public long? ServidorResponsavelId { get; set; }
        public Servidor? ServidorResponsavel { get; set; }

        public int? LocalId { get; set; }
        public Local? Local { get; set; }

        public ICollection<Servidor>? Servidores { get; set; }
        public ICollection<Processo>? Processos { get; set; }

    }
}