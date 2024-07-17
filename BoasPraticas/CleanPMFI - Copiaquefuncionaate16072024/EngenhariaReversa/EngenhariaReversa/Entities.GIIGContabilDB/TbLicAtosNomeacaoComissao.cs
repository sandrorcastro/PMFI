using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicAtosNomeacaoComissao
    {
        public TbLicAtosNomeacaoComissao()
        {
            TbLicAtosNomeacaoComissaoPessoas = new HashSet<TbLicAtosNomeacaoComissaoPessoa>();
        }

        public int IdAtoNomeacao { get; set; }
        public short? IdEmpresa { get; set; }
        public int? CdComissao { get; set; }
        public int? NrAtoNomeacao { get; set; }
        public short? NrAnoAto { get; set; }
        public DateTime? DtPublicacaoAto { get; set; }
        public short? IdTipoComissao { get; set; }
        public DateTime? DtInicioVigencia { get; set; }
        public DateTime? DtFimVigencia { get; set; }
        public int? IdLeiAto { get; set; }

        public virtual TbLicTiposComissao? IdTipoComissaoNavigation { get; set; }
        public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; }
    }
}
