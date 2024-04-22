using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscAutoInfraco
    {
        public TribFiscAutoInfraco()
        {
            TribFiscAutoInfracaoPafs = new HashSet<TribFiscAutoInfracaoPaf>();
            TribFiscAutoInfracoesAnexos = new HashSet<TribFiscAutoInfracoesAnexo>();
            TribFiscAutoInfracoesItensVistoria = new HashSet<TribFiscAutoInfracoesItensVistorium>();
        }

        public int AutoId { get; set; }
        public short? AutoAno { get; set; }
        public int? NotifId { get; set; }
        public short? Idmoeda { get; set; }
        public DateTime? AutoData { get; set; }
        public int? FiscalId { get; set; }
        public decimal? AutoValor { get; set; }
        public DateTime? AutoDataNotificado { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? AutoDescricao { get; set; }
        public string? AutoSituacao { get; set; }
        public string? AutoMotivoSituacao { get; set; }
        public int? AutoNumero { get; set; }

        public virtual TribFiscFiscai? Fiscal { get; set; }
        public virtual TribFiscNotificaco? Notif { get; set; }
        public virtual ICollection<TribFiscAutoInfracaoPaf> TribFiscAutoInfracaoPafs { get; set; }
        public virtual ICollection<TribFiscAutoInfracoesAnexo> TribFiscAutoInfracoesAnexos { get; set; }
        public virtual ICollection<TribFiscAutoInfracoesItensVistorium> TribFiscAutoInfracoesItensVistoria { get; set; }
    }
}
