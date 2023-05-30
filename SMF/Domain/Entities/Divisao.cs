namespace Domain.Entities
{
    public class Divisao
    {
        public int DivisaoId { get; set; }
        public int UnidadeId { get; set; }
        public Unidade Unidade { get; set; }
        public ICollection<Servidor> Servidores { get; set; }

    }
}