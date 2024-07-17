using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribNotificacaoDivida
    {
        public long NotificacaoId { get; set; }
        public DateTime? NotificacaoData { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public short? NotificacaoAno { get; set; }
        public long? NotificacaoNumero { get; set; }
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
        public string? Entregue { get; set; }
        public int? ObjetoId { get; set; }
        public string? BoleNossoNumero { get; set; }
        public string? ComDesconto { get; set; }
        public int? TextoIdcapa { get; set; }

        public virtual TribBoleto? BoleNossoNumeroNavigation { get; set; }
        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribObjeto? Objeto { get; set; }
        public virtual TribTexto? Texto { get; set; }
    }
}
