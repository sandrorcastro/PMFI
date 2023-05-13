namespace Domain.Entities
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        public ICollection<Estado>? Estados { get; set; }
    }
}
