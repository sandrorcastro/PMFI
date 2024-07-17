using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTiposComissao
    {
        public TbLicTiposComissao()
        {
            TbLicAtosNomeacaoComissaos = new HashSet<TbLicAtosNomeacaoComissao>();
        }

        public short IdTipoComissao { get; set; }
        public string? NmTipoComissao { get; set; }

        public virtual ICollection<TbLicAtosNomeacaoComissao> TbLicAtosNomeacaoComissaos { get; set; }
    }
}
