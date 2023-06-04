namespace Domain.Entities
{
    public class Servidor_TipoProcesso
    {
       public long? ServidorId { get; set; }
       public Servidor? Servidor { get; set; }
       public int? TipoProcessoId { get; set; }
       public TipoProcesso? TipoProcesso { get; set; }
    }
}