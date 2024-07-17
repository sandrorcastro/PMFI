using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicAtosNomeacaoComissaoPessoa
    {
        public TbLicAtosNomeacaoComissaoPessoa()
        {
            TbLicComposicoesComissaos = new HashSet<TbLicComposicoesComissao>();
        }

        public int IdAtoNomeacaoPessoa { get; set; }
        public int? IdAtoNomeacao { get; set; }
        public int? IdPessoa { get; set; }
        public short? IdTipoAtribuicaoComissao { get; set; }
        public short? IdNaturezaCargoServidor { get; set; }
        public string? DsCargo { get; set; }

        public virtual TbLicAtosNomeacaoComissao? IdAtoNomeacaoNavigation { get; set; }
        public virtual TbLicNaturezasCargosServidore? IdNaturezaCargoServidorNavigation { get; set; }
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
        public virtual TbLicTiposAtribuicaoComisso? IdTipoAtribuicaoComissaoNavigation { get; set; }
        public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; }
    }
}
