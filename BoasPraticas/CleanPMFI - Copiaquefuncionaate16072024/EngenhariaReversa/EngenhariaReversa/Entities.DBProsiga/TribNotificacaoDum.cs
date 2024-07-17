using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribNotificacaoDum
    {
        public long NotificacaoDaid { get; set; }
        public DateTime? NotificacaoDadata { get; set; }
        public long? LivroDaid { get; set; }
        public short? NotificacaoDaano { get; set; }
        public long? NotificacaoDanumero { get; set; }
        /// <summary>
        /// Texto da notificação.
        /// </summary>
        public long? TextoId { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? Host { get; set; }
        /// <summary>
        /// Marca se a notificação foi entregue ao contribuinte.
        /// </summary>
        public string Entregue { get; set; } = null!;
        public int? ObjetoId { get; set; }
        public string? BoleNossoNumero { get; set; }

        public virtual TribBoleto? BoleNossoNumeroNavigation { get; set; }
        public virtual TribLivroDividaAtiva? LivroDa { get; set; }
        public virtual TribObjeto? Objeto { get; set; }
        public virtual TribTexto? Texto { get; set; }
    }
}
