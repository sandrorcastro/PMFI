using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSaneparArquivoBaixa
    {
        public TribSaneparArquivoBaixa()
        {
            TribSaneparArquivoBaixaDetalhes = new HashSet<TribSaneparArquivoBaixaDetalhe>();
        }

        public int SaneArqId { get; set; }
        public string? SaneArqNome { get; set; }
        public short? SaneArqMes { get; set; }
        public short? SaneArqAno { get; set; }
        public DateTime? SaneArqDataInclusao { get; set; }
        public string? SaneArqUsuario { get; set; }

        public virtual ICollection<TribSaneparArquivoBaixaDetalhe> TribSaneparArquivoBaixaDetalhes { get; set; }
    }
}
