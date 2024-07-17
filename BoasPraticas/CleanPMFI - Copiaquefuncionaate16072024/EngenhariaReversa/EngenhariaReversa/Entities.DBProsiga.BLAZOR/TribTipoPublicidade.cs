using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribTipoPublicidade
    {
        public TribTipoPublicidade()
        {
            TribEmpresasPublicidades = new HashSet<TribEmpresasPublicidade>();
        }

        public int PublicTipoId { get; set; }
        public string? PublicTipoNome { get; set; }
        public decimal PublicQtdeUfm { get; set; }
        /// <summary>
        /// Tipo da Base Calculo
        /// </summary>
        public int? Tcid { get; set; }
        /// <summary>
        /// Unidade de medida da Publicidade
        /// </summary>
        public int? UnMedId { get; set; }

        public virtual TribTiposBaseCalculo? Tc { get; set; }
        public virtual AlmUnMed? UnMed { get; set; }
        public virtual ICollection<TribEmpresasPublicidade> TribEmpresasPublicidades { get; set; }
    }
}
