namespace Domain.Entities
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string? Descricao { get; set; }
        public string? Sigla { get; set; }
        public int? PaisId { get; set; }
        public Pais? Pais { get; set; }

        public ICollection<Cidade>? Cidades { get; set; }

       

    }      
}
