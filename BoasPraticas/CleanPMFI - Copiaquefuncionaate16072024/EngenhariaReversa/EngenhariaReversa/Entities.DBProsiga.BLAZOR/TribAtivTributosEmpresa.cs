using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAtivTributosEmpresa
    {
        public TribAtivTributosEmpresa()
        {
            TribAtividadeTipoAlvaraTributos = new HashSet<TribAtividadeTipoAlvaraTributo>();
        }

        public string Atividade { get; set; } = null!;
        public int TipoTribId { get; set; }
        public int Tcid { get; set; }
        public string? PeriodoIncidencia { get; set; }
        public string? GeraDividaAutomaticaNoAlvara { get; set; }
        /// <summary>
        /// Informa se o tributo incide nas Empresas Não Estabelecidas
        /// </summary>
        public string IncideNosDomicilioTributario { get; set; } = null!;
        /// <summary>
        /// Quantidade UF para este tributo dentro da atividade
        /// </summary>
        public decimal QtdeUf { get; set; }
        public int? ParamCalcId { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual TribEmpresasParamCalc? ParamCalc { get; set; }
        public virtual TribTiposBaseCalculo Tc { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
        public virtual ICollection<TribAtividadeTipoAlvaraTributo> TribAtividadeTipoAlvaraTributos { get; set; }
    }
}
