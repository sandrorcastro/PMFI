namespace Domain.Entities
{ 
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string? Descricao { get; set; }
        public int? EstadoId { get; set; }
        public int? ibgeProsiga { get; set; }
        public int? ibge { get; set; }
        public int? IDCidadeProsiga { get; set; }
        public string? UFProsiga { get; set; }
        public Estado? Estado { get; set;}
        public int? DDDId { get; set; }
        public DDD? DDD { get; set; }
        public ICollection<Bairro>? Bairros { get; set; }
        public ICollection<Logradouro>? Logradouros { get; set; }

    }
}
