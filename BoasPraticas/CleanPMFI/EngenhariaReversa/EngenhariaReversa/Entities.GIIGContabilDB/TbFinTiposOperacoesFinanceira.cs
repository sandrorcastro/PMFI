using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTiposOperacoesFinanceira
    {
        public TbFinTiposOperacoesFinanceira()
        {
            TbFinContasContabeisLancamentosAnalisadors = new HashSet<TbFinContasContabeisLancamentosAnalisador>();
            TbFinDiarioTesouraria = new HashSet<TbFinDiarioTesourarium>();
            IdTipoDocFinanceiros = new HashSet<TbFinTiposDocumentoFinanceiro>();
        }

        public short IdTipoOperacaoFinanceira { get; set; }
        public string? DsTipoOperacaoFinanceira { get; set; }
        public string? FlLancaManual { get; set; }
        public string? FlExigeIdContaTransferencia { get; set; }
        public string? FlExigeIdContaContabilContrapartida { get; set; }
        public string? FlExigeIdOrigemDestino { get; set; }

        public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; }
        public virtual ICollection<TbFinDiarioTesourarium> TbFinDiarioTesouraria { get; set; }

        public virtual ICollection<TbFinTiposDocumentoFinanceiro> IdTipoDocFinanceiros { get; set; }
    }
}
