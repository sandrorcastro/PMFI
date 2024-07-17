using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribBaixaMovimento
    {
        public long Idbaixa { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public int? TipoBxId { get; set; }
        public decimal? MoBaValorBaixa { get; set; }
        public DateTime? MoBaDataBaixa { get; set; }
        /// <summary>
        /// Data do sistema que foi efetuado a movimentação
        /// </summary>
        public DateTime? MoBaDataInclusao { get; set; }
        /// <summary>
        /// Usuário que incluiu a baixa
        /// </summary>
        public string? MoBaUsuario { get; set; }
        /// <summary>
        /// Nome da maquina que fez a baixa.
        /// </summary>
        public string? MoBaHost { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
    }
}
