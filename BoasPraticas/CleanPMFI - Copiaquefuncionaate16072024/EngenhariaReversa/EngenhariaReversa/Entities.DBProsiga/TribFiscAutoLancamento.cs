using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscAutoLancamento
    {
        public int AutoLanId { get; set; }
        public short? AutoLanAno { get; set; }
        public int? NotifId { get; set; }
        public short? Idmoeda { get; set; }
        public DateTime? AutoLanData { get; set; }
        public int? FiscalId { get; set; }
        public decimal? AutoLanValor { get; set; }
        public DateTime? AutoLanDataNotificado { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? AutoLanDescricao { get; set; }
        public string? AutoLanSituacao { get; set; }
        public string? AutoLanMotivoSituacao { get; set; }
        public int? AutoLanNumero { get; set; }
    }
}
