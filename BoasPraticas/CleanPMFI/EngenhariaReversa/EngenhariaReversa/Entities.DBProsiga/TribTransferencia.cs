using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTransferencia
    {
        public long TransfId { get; set; }
        public long? EdificacaoId { get; set; }
        public long? DeConId { get; set; }
        public long? ParaConId { get; set; }
        public DateTime? DataTransfAnterior { get; set; }
        public DateTime? DataTransfAtual { get; set; }
        /// <summary>
        ///  (Manual ou Automática) Se o registro foi incluido manual sera calculado a taxa, se foi trigger ou conversão não calcula
        /// </summary>
        public string FormaInclusaoTransf { get; set; } = null!;
        public string? Observacao { get; set; }
        public int? ProcId { get; set; }

        public virtual Contribuinte? DeCon { get; set; }
        public virtual TribEdificaco? Edificacao { get; set; }
        public virtual Contribuinte? ParaCon { get; set; }
    }
}
