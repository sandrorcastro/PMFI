using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaDado
    {
        public int CodaId { get; set; }
        public int? ConsId { get; set; }
        public string? CodaNome { get; set; }
        public string? CodaCep { get; set; }
        public string? CodaEndereco { get; set; }
        public string? CodaTransversais { get; set; }
        public string? CodaFundos { get; set; }
        public string? CodaInscricao { get; set; }
        public short? CodaNumeroPav { get; set; }
        public string? CodaProprietario { get; set; }
        public string? CodaRequerente { get; set; }
        public string? CodaContador { get; set; }
        public string? CodaFoneContato { get; set; }
        public string? CodaInformacao { get; set; }
        public decimal? CodaAreaCoberta { get; set; }
        public decimal? CodaAreaDescoberta { get; set; }
        public string? CodaAtividade { get; set; }
        public short? IdTipoContribuinte { get; set; }
        public int? IdTipoInstalacao { get; set; }
        public string? VlTipoInstalacao { get; set; }
        public string? CodaRequerenteCnpjcpf { get; set; }
        public string? IdAtividadePrincipal { get; set; }

        public virtual TabConsultum? Cons { get; set; }
        public virtual TabTipoContribuinte? IdTipoContribuinteNavigation { get; set; }
    }
}
