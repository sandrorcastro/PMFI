using System.Runtime.CompilerServices;

namespace Domain.Entities
{
    public class RG : DocumentoPessoa
    {
        public DateTime? DataExpedicao { get; set; }
        public int? EstadoEmissorId { get; set; }
        public Estado? EstadoEmissor { get; set; }
        public string? OrgaoEmissor { get; set; }

    }
}