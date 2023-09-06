using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbParTiposIntegracao
    {
        public TbParTiposIntegracao()
        {
            TbParIntegracaoParametros = new HashSet<TbParIntegracaoParametro>();
            TbParIntegracoesContabeis = new HashSet<TbParIntegracoesContabei>();
        }

        public short IdTipoIntegracao { get; set; }
        public short? IdEmpresa { get; set; }
        public string? NmTipoIntegracao { get; set; }
        public string? DsSigla { get; set; }
        public DateTime? DtAtivacao { get; set; }
        public DateTime? DtInativacao { get; set; }

        public virtual ICollection<TbParIntegracaoParametro> TbParIntegracaoParametros { get; set; }
        public virtual ICollection<TbParIntegracoesContabei> TbParIntegracoesContabeis { get; set; }
    }
}
