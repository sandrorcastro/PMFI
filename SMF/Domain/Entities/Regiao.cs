namespace Domain.Entities
{
    public class Regiao
    {
        public long RegiaoId { get; set; }   
        public string? Descricao { get; set; }
        public int? CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
        public float? PercentualUVC { get; set;  }
        public string? CentroGrauLon { get; set; }
        public string? CentroGrauLat { get; set; }   

    }
}
