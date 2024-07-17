using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerTiposBaixaResponsavel
    {
        public TbGerTiposBaixaResponsavel()
        {
            TbGerContasCorrentesResponsaveis = new HashSet<TbGerContasCorrentesResponsavei>();
        }

        public short IdTipoBaixa { get; set; }
        public string? DsTipoBaixa { get; set; }

        public virtual ICollection<TbGerContasCorrentesResponsavei> TbGerContasCorrentesResponsaveis { get; set; }
    }
}
