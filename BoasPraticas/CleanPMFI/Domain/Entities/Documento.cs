using Domain.Enums;

namespace Domain.Entities
{
    public class Documento
    {
        public long IdDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        public string Numero { get; set; }
    }
}