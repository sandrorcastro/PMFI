using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTiposAtribuicaoComisso
    {
        public TbLicTiposAtribuicaoComisso()
        {
            TbLicAtosNomeacaoComissaoPessoas = new HashSet<TbLicAtosNomeacaoComissaoPessoa>();
            TbLicComposicoesComissaos = new HashSet<TbLicComposicoesComissao>();
        }

        public short IdTipoAtribuicaoComissao { get; set; }
        public string? NmTipoAtribuicaoComissao { get; set; }
        public short? CdTc { get; set; }

        public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; }
        public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; }
    }
}
