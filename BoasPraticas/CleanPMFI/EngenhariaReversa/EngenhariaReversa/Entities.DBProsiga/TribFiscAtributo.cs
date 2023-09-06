using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscAtributo
    {
        public TribFiscAtributo()
        {
            TribFiscVistoriasAtributos = new HashSet<TribFiscVistoriasAtributo>();
            TipoVists = new HashSet<TribFiscTiposVistorium>();
        }

        /// <summary>
        /// Código de identificação dos atributos.
        /// </summary>
        public int IdAtributo { get; set; }
        /// <summary>
        /// Nome do atributo.
        /// </summary>
        public string? NmAtributo { get; set; }

        public virtual ICollection<TribFiscVistoriasAtributo> TribFiscVistoriasAtributos { get; set; }

        public virtual ICollection<TribFiscTiposVistorium> TipoVists { get; set; }
    }
}
