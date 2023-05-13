namespace Domain.Entities
{
    public class Loteamento
    {
        public int LoteamentoId { get; set; }
        public string? Descricao { get; set; }
        public long? RegiaoId { get; set; }
        public Regiao? Regiao { get; set; }
        public DateTime? DataCadastro { get; set; }

       
    }
}
